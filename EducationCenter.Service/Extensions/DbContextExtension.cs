using EducationCenter.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EducationCenter.Service.Extensions
{
    public static class DbContextExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseNpgsql(
                    configuration.GetConnectionString("DevelopmentPostgreSQLConnectionString"))
                );
        }
    }
}
