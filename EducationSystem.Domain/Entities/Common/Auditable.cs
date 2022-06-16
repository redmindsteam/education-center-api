using System.ComponentModel.DataAnnotations;

namespace EducationSystem.Domain.Entities.Common
{
    public abstract class Auditable
    {
        [Required]
        public long Id { get; set; }

        public string CreatedDate { get; private set; } = DateTime.Now.ToString("dd.MM.yy HH:mm");

        public string UpdatedDate { get; set; } = DateTime.Now.ToString("dd.MM.yy HH:mm");
    }
}
