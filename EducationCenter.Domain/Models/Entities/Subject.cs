using EducationCenter.Domain.Common;
using System.Collections.Generic;

namespace EducationCenter.Domain.Models.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; private set; }

        public virtual ICollection<Group> Groups { get; private set; }

        public Subject()
        {
            Teachers = new HashSet<Teacher>();
            Groups = new HashSet<Group>();
        }
    }
}
