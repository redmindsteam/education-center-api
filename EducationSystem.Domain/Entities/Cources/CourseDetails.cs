using EducationSystem.Domain.Entities.Common;

namespace EducationSystem.Domain.Entities.Cources
{
    public class CourseDetail : Auditable
    {
        public long CourseId { get; set; }
        public virtual Course Course { get; set; }

        public string BeginTime { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public string EndTime { get; set; }
    }
}
