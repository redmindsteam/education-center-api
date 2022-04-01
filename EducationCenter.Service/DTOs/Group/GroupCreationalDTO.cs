using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Service.DTOs.Group
{
    public class GroupCreationalDTO
    {
        [MaxLength(12)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
    }
}
