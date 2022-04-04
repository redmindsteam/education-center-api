using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Subject;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : GenericController<Subject, SubjectInputDTO>
    {
        public SubjectsController(IGenericService<Subject, SubjectInputDTO> service) : base(service)
        {
        }
    }
}
