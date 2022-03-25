using System.Collections.Generic;

namespace EducationCenter.Domain.Models.Entities
{
    public class Teacher : Employee
    {
        public virtual ICollection<Subject> Subjects { get; set; }

        public virtual ICollection<Group> Groups { get; private set; }

        public Teacher()
        {
            Subjects = new HashSet<Subject>();
            Groups = new HashSet<Group>();
        }
    }
}
