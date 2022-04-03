using AutoMapper;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.DTOs.Room;
using EducationCenter.Service.DTOs.Student;
using EducationCenter.Service.DTOs.Subject;
using EducationCenter.Service.DTOs.Teacher;

namespace EducationCenter.Service.Mapping
{
    public class MappingConfigure : Profile
    {
        public MappingConfigure()
        {
            CreateMap<Employee, EmployeeCreationalDTO>().ReverseMap();
            CreateMap<Group, GroupCreationalDTO>().ReverseMap();
            CreateMap<Room, RoomCreationalDTO>().ReverseMap();
            CreateMap<Student, StudentCreationalDTO>().ReverseMap();
            CreateMap<Subject, SubjectCreationalDTO>().ReverseMap();
            CreateMap<Teacher, TeacherCreationalDTO>().ReverseMap();

        }
    }
}
