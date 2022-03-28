using EducationCenter.Service.Extensions;
using EducationCenter.Service.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EducationCenter.Service
{
    public static class DependencyInjection
    {
        public static void ConfigureServiceLayer(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.ConfigureRepasitories();
            services.ConfigureServices();
            services.ConfigureDbContext(configuration);
            services.AddAutoMapper(typeof(MappingConfigure));
        }
    }
}
