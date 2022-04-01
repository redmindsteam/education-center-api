using AutoMapper;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Service.Mapping
{
    public class MappingConfigure : Profile
    {
        public MappingConfigure()
        {
            CreateMap<Employee, EmployeeCreationalDTO>().ReverseMap();
            CreateMap<Group, GroupCreationalDTO>().ReverseMap();
            CreateMap<Student, StudentCreationalDTO>().ReverseMap();
        }
    }
}
