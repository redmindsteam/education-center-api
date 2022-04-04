using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Student;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : GenericController<Student, StudentInputDTO>
    {
        public StudentsController(IGenericService<Student, StudentInputDTO> service) : base(service)
        {
        }
    }
}
