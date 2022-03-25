using EducationCenter.Domain.Common;
using System.Collections.Generic;

namespace EducationCenter.Domain.Models.Entities
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public Room()
        {
            Groups = new HashSet<Group>();
        }
    }
}
