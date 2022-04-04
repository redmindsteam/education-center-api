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
            services.AddScoped<IGenericService<Employee, EmployeeInputDTO>, 
                GenericService<Employee, EmployeeInputDTO>>();

            services.AddScoped<IGenericService<Group, GroupInputDTO>,
                GenericService<Group, GroupInputDTO>>();

            services.AddScoped<IGenericService<Room, RoomInputDTO>,
                GenericService<Room, RoomInputDTO>>();

            services.AddScoped<IGenericService<Student, StudentInputDTO>,
                GenericService<Student, StudentInputDTO>>();

            services.AddScoped<IGenericService<Subject, SubjectInputDTO>,
                GenericService<Subject, SubjectInputDTO>>();

            services.AddScoped<IGenericService<Teacher, TeacherInputDTO>,
                GenericService<Teacher, TeacherInputDTO>>();
        }
    }
}
