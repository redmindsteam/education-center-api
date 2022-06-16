using EducationSystem.Domain.Entities.Common;
using EducationSystem.Domain.Entities.Teachers;

namespace EducationSystem.Domain.Entities.Cources
{
    public class CourseTeacher : Auditable
    {
        public long CourseId { get; set; }
        public virtual Course Course { get; set; }

        public long TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
