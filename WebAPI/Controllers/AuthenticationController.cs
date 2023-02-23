using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Entity;
using WebAPI.Model;
using WebAPI.Model.Repository;
using WebAPI.Model.Auth;
using Microsoft.Extensions.Options;
using WebAPI.Models.Shared;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController : BaseController
    {
        private readonly IFunctionService functionService;
        private readonly UserManager<SystemUser> userManager;
        private readonly RoleManager<SystemRole> roleManager;
        private readonly IConfiguration _configuration;
        //private readonly IConfigurationSection _configurationSection;
        private readonly JwtBearerTokenSettings jwtBearerTokenSettings;

        public AuthenticationController(IFunctionService functionService, UserManager<SystemUser> userManager, RoleManager<SystemRole> roleManager, IConfiguration configuration
            //, IConfigurationSection configurationSection
            ,IOptions<JwtBearerTokenSettings> jwtTokenOptions
            ,IOptions<WebApiPath> webApiPath
            )
        {
            this.functionService = functionService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            //_configurationSection = configurationSection;
            this.jwtBearerTokenSettings = jwtTokenOptions.Value;
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AuthInfo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.Username);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                //var jwtBearerTokenSettings = _configurationSection.Get<JwtBearerTokenSettings>();
                //var key = Encoding.UTF8.GetBytes(jwtBearerTokenSettings.SecretKey);

                foreach (var provider in _configuration.GetChildren())
                {
                    System.Diagnostics.Debug.WriteLine(provider.Key);
                    System.Diagnostics.Debug.WriteLine(provider.Value);
                }

                var key = Encoding.UTF8.GetBytes(jwtBearerTokenSettings.SecretKey);
                //var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
                //var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtBearerTokenSettings:Secret"]));
                var authSigningKey = new SymmetricSecurityKey(key);

                var jwtToken = new JwtSecurityToken(
                    issuer: jwtBearerTokenSettings.Issuer,
                    audience: jwtBearerTokenSettings.Audience,
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                //return Ok(new
                //{
                //    token = new JwtSecurityTokenHandler().WriteToken(token),
                //    expiration = token.ValidTo
                //});
                var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
                var routes = functionService.GetRoutes(userRoles, model.ApplicationCode);
                return Ok(new AuthInfo { AccessToken = token, Routes = routes, TwoFA = false });
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            SystemUser user = new SystemUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            SystemUser user = new SystemUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new SystemRole(UserRoles.Admin));
            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new SystemRole(UserRoles.User));

            if (await roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await userManager.AddToRoleAsync(user, UserRoles.Admin);
            }

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [Authorize]
        [HttpGet("Logout")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Logout()
        {
            //TODO: update log
            UserDetails userDetails = base.GetUserDetails();
            //Log.Info($"{userDetails.UserName} Logout");
            return Ok(true);
        }
    }
}
