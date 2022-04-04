using EducationCenter.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Domain.Models.Entities
{
    public class RoomGroup : BaseEntity
    {
        [Required]
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        [Required]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
