using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.DTOs.Room;
using EducationCenter.Service.DTOs.Student;
using EducationCenter.Service.DTOs.Subject;
using EducationCenter.Service.DTOs.Teacher;
using EducationCenter.Service.IServices;
using EducationCenter.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EducationCenter.Service.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            // Generic reletionals
            services.AddScoped<IGenericService<Employee, EmployeeCreationalDTO>, 
                GenericService<Employee, EmployeeCreationalDTO>>();

            services.AddScoped<IGenericService<Group, GroupCreationalDTO>,
                GenericService<Group, GroupCreationalDTO>>();

            services.AddScoped<IGenericService<Room, RoomCreationalDTO>,
                GenericService<Room, RoomCreationalDTO>>();

            services.AddScoped<IGenericService<Student, StudentCreationalDTO>,
                GenericService<Student, StudentCreationalDTO>>();

            services.AddScoped<IGenericService<Subject, SubjectCreationalDTO>,
                GenericService<Subject, SubjectCreationalDTO>>();

            services.AddScoped<IGenericService<Teacher, TeacherCreationalDTO>,
                GenericService<Teacher, TeacherCreationalDTO>>();
        }
    }
}
