using EducationCenter.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducationCenter.Domain.Models.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

        public virtual ICollection<LessonTimeDetail> LessonTimeDetails { get; set; }

        public Group()
        {
            Subjects = new HashSet<Subject>();
            LessonTimeDetails = new HashSet<LessonTimeDetail>();
        }
    }
}
