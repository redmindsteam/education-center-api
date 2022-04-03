using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Room;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : GenericController<Room, RoomCreationalDTO>
    {
        public RoomsController(IGenericService<Room, RoomCreationalDTO> service) : base(service)
        {
        }
    }
}
