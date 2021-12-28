using Employee.Core.Contracts;
using Employee.Core.Services;
using Employee.Repo.Contracts;
using Employee.Repo.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Employee.API.Configs
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            // Services
            services.AddScoped<INotification, Notification>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            // Repositories
            services.AddScoped<IRepository<Entity.Models.Employee>, FakeEmployeeRepository>();
        }
    }
}
