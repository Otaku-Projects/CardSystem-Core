using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddMicrosoftIdentityWebApi(Configuration.GetSection("WebApiDatabase"));
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");


            services
            .AddControllers()
            .AddNewtonsoftJson(options =>
            {
                // fixed: System.Text.Json.JsonException: A possible object cycle was detected.
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            // if using Swashbuckle
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "WebAPI",
                    Description = "An ASP.NET Core Web API for managing ToDo items",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    }
                });
            });

            // if using NSwag
            // Register the Swagger services
            //services.AddSwaggerDocument(config =>
            //{
            //    config.PostProcess = document =>
            //    {
            //        document.Info.Version = "v1";
            //        document.Info.Title = "ToDo API";
            //        document.Info.Description = "A simple ASP.NET Core web API";
            //        document.Info.TermsOfService = "None";
            //        document.Info.Contact = new NSwag.OpenApiContact
            //        {
            //            Name = "Shayne Boyer",
            //            Email = string.Empty,
            //            Url = "https://twitter.com/spboyer"
            //        };
            //        document.Info.License = new NSwag.OpenApiLicense
            //        {
            //            Name = "Use under LICX",
            //            Url = "https://example.com/license"
            //        };
            //    };
            //});

            /*
             * AddAutomapper method
             It automatically scans for Mappingprofile contain mapping configuration
             */
            //services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); // same as above, but its better not use the class name

            AuthenticationConfig.Initialize(services, Configuration.GetSection("JwtBearerTokenSettings"));
            ContainerConfig.Initialize(services, connectionString);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if using Swashbuckle
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }
            app.UseStaticFiles();

            // if using NSwag
            // Register the Swagger generator and the Swagger UI middlewares
            //app.UseOpenApi();
            //app.UseSwaggerUi3();

            app.UseHttpsRedirection();
            app.UseCors(x => 
            {
                x.AllowAnyOrigin();
                x.AllowAnyMethod();
                x.AllowAnyHeader();
            });

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
