using EducationCenter.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Domain.Models.Entities
{
    public class TeacherGroup : BaseEntity
    {
        [Required]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; private set; }

        [Required]
        public int GroupId { get; set; }
        public virtual Group Group { get; private set; }

        public DateTime RegistrationDate { get; set; }
    }
}
