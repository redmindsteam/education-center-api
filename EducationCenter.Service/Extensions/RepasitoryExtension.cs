using EducationCenter.Data.IRepositories;
using EducationCenter.Data.Repositories;
using EducationCenter.Domain.Models.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace EducationCenter.Service.Extensions
{
    public static class RepasitoryExtension
    {
        public static void ConfigureRepasitories(this IServiceCollection services)
        {
            // Generic Reletions
            services.AddScoped<IGenericRepository<Employee>, GenericRepository<Employee>>();
            services.AddScoped<IGenericRepository<Group>, GenericRepository<Group>>();
            services.AddScoped<IGenericRepository<Person>, GenericRepository<Person>>();
            services.AddScoped<IGenericRepository<Room>, GenericRepository<Room>>();
            services.AddScoped<IGenericRepository<Student>, GenericRepository<Student>>();
            services.AddScoped<IGenericRepository<Subject>, GenericRepository<Subject>>();
            services.AddScoped<IGenericRepository<Teacher>, GenericRepository<Teacher>>();
        }
    }
}
