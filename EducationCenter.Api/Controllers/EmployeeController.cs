using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController
        : GenericController<Employee, EmployeeCreationalDTO>
    {
        public EmployeeController(IGenericService<Employee, EmployeeCreationalDTO> service) : base(service)
        {
        }
    }
}
