using Employee.Core.Interfaces;
using Employee.Core.Services;
using Employee.Infrastructure.Data;
using Employee.SharedKernel.Interfaces;
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
            services.AddScoped<IRepository<Core.Entities.Employee>, FakeEmployeeRepository>();
        }
    }
}
