using AutoMapper;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
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

        }
    }
}
