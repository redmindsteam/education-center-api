using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Room;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : GenericController<Room, RoomInputDTO>
    {
        public RoomsController(IGenericService<Room, RoomInputDTO> service) : base(service)
        {
        }
    }
}
