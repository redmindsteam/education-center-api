using System.Collections.Generic;

namespace EducationCenter.Domain.Models.Entities
{
    public class Student : Person
    {
        public virtual ICollection<Group> Groups { get; private set; }

        public Student()
        {
            Groups = new HashSet<Group>();
        }
    }
}
