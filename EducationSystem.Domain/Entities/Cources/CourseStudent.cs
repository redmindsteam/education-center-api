using EducationSystem.Domain.Entities.Common;
using EducationSystem.Domain.Entities.Students;

namespace EducationSystem.Domain.Entities.Cources
{
    public class CourseStudent : Auditable
    {
        public long CourseId { get; set; }
        public virtual Course Course { get; set; }

        public long StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}
