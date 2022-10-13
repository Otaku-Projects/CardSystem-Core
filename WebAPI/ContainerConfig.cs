using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WebAPI.DataContext;
using WebAPI.Model;
using WebAPI.Model.Repository;
using WebAPI.Repository;

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
            //services.AddTransient<IFunctionService, FunctionService>();
            //services.AddTransient<IApplicationService, ApplicationService>();
            //services.AddTransient<IReportService, ReportService>();

            ////Helpers
            //services.AddSingleton<IAutoMappingHelper, AutoMappingHelper>();
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


        }
    }
}
