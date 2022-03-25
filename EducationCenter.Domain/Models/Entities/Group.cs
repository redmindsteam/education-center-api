using EducationCenter.Domain.Models.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Domain.Models.Entities
{
    public class Group : BaseEntity
    {
        [MaxLength(12)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; } 

        public virtual ICollection<Subject> Subjects { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<LessonTimeDetail> LessonTimeDetails { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public Group()
        {
            Teachers = new HashSet<Teacher>();
            Subjects = new HashSet<Subject>();
            Students = new HashSet<Student>();
            LessonTimeDetails = new HashSet<LessonTimeDetail>();
            Rooms = new HashSet<Room>();
        }
    }
}
