using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Student;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : GenericController<Student, StudentCreationalDTO>
    {
        public StudentsController(IGenericService<Student, StudentCreationalDTO> service) : base(service)
        {
        }
    }
}
