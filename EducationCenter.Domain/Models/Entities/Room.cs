using EducationCenter.Domain.Common;

namespace EducationCenter.Domain.Models.Entities
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
