using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WebAPI.DataContext;
using WebAPI.Helper;
using WebAPI.Model;
using WebAPI.Model.Repository;
using WebAPI.Repository;
using WebAPI.Services;

namespace WebAPI
{
    public class ContainerConfig
    {
        public static void Initialize(IServiceCollection services, string connectionString)
        {
            ConfigureContainer(services, connectionString);
        }

        private static void ConfigureContainer(IServiceCollection services, string connectionString)
        {
            //DB
            //services.AddDbContext<CoreDataContext>(options => options.UseMySQL(connectionString));
            //services.AddDbContext<CoreDataContext>(options => options.UseSqlServer(connectionString));

            services.AddDbContext<CoreDataContext>(opts => opts.UseSqlServer(connectionString));

            //Services
            //services.AddTransient<IUserService, UserService>();
            //services.AddTransient<IRoleService, RoleService>();
            //services.AddTransient<IAuthService, AuthService>();
            //services.AddTransient<IFileService, FileService>();
            services.AddTransient<IFunctionService, FunctionService>();
            //services.AddTransient<IApplicationService, ApplicationService>();
            //services.AddTransient<IReportService, ReportService>();

            ////Helpers
            services.AddSingleton<IAutoMappingHelper, AutoMappingHelper>();
            //services.AddSingleton<IFileHelper, FileHelper>();

            ////Repository
            //services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddTransient(typeof(IidentityRepository<>), typeof(IdentityRepository<>));

            ////Unit of work
            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Unit of work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services.AddScoped<IDataRepository<Employee>, EmployeeManager>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeEmergencyContactRepository, EmployeeEmergencyContactRepository>();

            services.AddTransient<IRepositoryWrapperEmployee, RepositoryWrapperEmployee>();

            services.AddTransient<IRepositoryWrapperSystemUser, RepositoryWrapperSystemUser>();

            /***
             * 
             * ASP.NET Core 提供 3 種方法來註冊服務到依賴註入容器中。 而我們使用的方法決定了註冊服務的生命周期。
             * 
             * AddSingleton() : register service DI Singleton 服務。首次請求時會創建 Singleton 服務。然後，所有後續的請求中都會使用相同的實例。因此，通常，每個應用程式只創建一次 Singleton 服務，並且在整個應用程式生命周期中使用該單個實例。
             * The AddSingleton method registers the service, create instance once, only the same instance for every object and every request
             * 
             * AddTransient() :此方法創建一個 Transient 服務。每次請求時，都會創建一個新的 Transient 服務實例。
             * The AddTransient method registers the service, a new instance is provided to every controller and every service
             * 
             * AddScoped() - 此方法創建一個 Scoped 服務。在範圍內的每個請求中創建一個新的 Scoped 服務實例。
             * The AddScoped method registers the service with a scoped lifetime, the lifetime of a single request.
             */
        }
    }
}
