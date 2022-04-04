using System.Collections.Generic;

namespace EducationCenter.Domain.Models.Entities
{
    public class Teacher : Employee
    {
        public virtual ICollection<Subject> Subjects { get; set; }

        public Teacher()
        {
            Subjects = new HashSet<Subject>();
        }
    }
}
