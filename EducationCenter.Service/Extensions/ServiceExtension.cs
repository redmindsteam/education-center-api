using EducationCenter.Service.IServices;
using EducationCenter.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EducationCenter.Service.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}
