using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : GenericController<Group, GroupInputDTO>
    {
        public GroupsController(IGenericService<Group, GroupInputDTO> service) : base(service)
        {
        }
    }
}
