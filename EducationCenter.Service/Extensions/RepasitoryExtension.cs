using EducationCenter.Data.IRepositories;
using EducationCenter.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EducationCenter.Service.Extensions
{
    public static class RepasitoryExtension
    {
        public static void ConfigureRepasitories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
        }
    }
}
