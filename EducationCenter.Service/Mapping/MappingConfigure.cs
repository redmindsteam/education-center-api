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
            CreateMap<Employee, EmployeeInputDTO>().ReverseMap();
            CreateMap<Group, GroupInputDTO>().ReverseMap();
            CreateMap<Room, RoomInputDTO>().ReverseMap();
            CreateMap<Student, StudentInputDTO>().ReverseMap();
            CreateMap<Subject, SubjectInputDTO>().ReverseMap();
            CreateMap<Teacher, TeacherInputDTO>().ReverseMap();

        }
    }
}
