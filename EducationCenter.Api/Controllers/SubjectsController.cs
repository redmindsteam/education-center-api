using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Subject;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : GenericController<Subject, SubjectCreationalDTO>
    {
        public SubjectsController(IGenericService<Subject, SubjectCreationalDTO> service) : base(service)
        {
        }
    }
}
