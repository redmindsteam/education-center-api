using EducationCenter.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Domain.Models.Entities
{
    public class StudentGroup : BaseEntity
    {
        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; private set; }

        [Required]
        public int GroupId { get; set; }
        public virtual Group Group { get; private set; }

        public DateTime RegistrationDate { get; set; } 
            = DateTime.Now;
    }
}
