using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using WebAPI.DataContext;
using WebAPI.Model;

namespace WebAPI
{
    public class AuthenticationConfig
    {
        public static void Initialize(IServiceCollection services, IConfigurationSection configurationSection)
        {
            ConfigureAuth(services, configurationSection);
        }

        private static void ConfigureAuth(IServiceCollection services, IConfigurationSection configurationSection)
        {
            /**
             * We set the RequireConfirmedAccount to false. Otherwise, 
             * the user is not allowed to login 
             * until we send a email confirmation link to him and he confirms it by clicking on it.
             * */
            services.AddIdentity<SystemUser, SystemUserRole>(options => options.SignIn.RequireConfirmedAccount = false)
                            .AddEntityFrameworkStores<CoreDataContext>();

            var jwtBearerTokenSettings = configurationSection.Get<JwtBearerTokenSettings>();
            var key = Encoding.ASCII.GetBytes(jwtBearerTokenSettings.SecretKey);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtBearerTokenSettings.Issuer,
                    ValidateAudience = true,
                    ValidAudience = jwtBearerTokenSettings.Audience,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }
    }
}
