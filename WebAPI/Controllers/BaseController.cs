using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using WebAPI.Model.Auth;

namespace WebAPI.Controllers
{
    [Authorize]
    //[AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
        //public static readonly ILog log = LogManager.GetLogger(typeof(Program));

        public UserDetails AuthInfo => new UserDetails()
        {
            UserName = HttpContext.User.Identity.Name,
            NSUserId = HttpContext.User.Claims.Where(c => c.Type == "NSUserId").Select(c => c.Value).FirstOrDefault(),
            Email = HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).FirstOrDefault(),
            Roles = HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList(),
            //Regions = HttpContext.User.Claims.Where(c => c.Type == "Regions").Select(c => Convert.ToInt32(c.Value)).ToList(),
            UserId = HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).SingleOrDefault(),
            ChangePassword = Convert.ToBoolean(HttpContext.User.Claims.Where(c => c.Type == "ChangePassword").Select(c => c.Value).FirstOrDefault())
        };

        [ApiExplorerSettings(IgnoreApi = true)]
        public UserDetails GetUserDetails()
        {
            return AuthInfo;
        }
    }
}
