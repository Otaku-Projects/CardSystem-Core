using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WebAPI.DataContext;
using WebAPI.Model;
using WebAPI.Model.DataManager;
using WebAPI.Model.Repository;

namespace WebAPI
{
    public class SeedDataConfig
    {
        public static void Initialize(IServiceCollection services, string connectionString)
        {
            ConfigureContainer(services, connectionString);
        }

        private static void ConfigureContainer(IServiceCollection services, string connectionString)
        {
        }
    }
}
