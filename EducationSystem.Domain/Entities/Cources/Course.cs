using EducationSystem.Domain.Entities.Common;
using EducationSystem.Domain.Enums;

namespace EducationSystem.Domain.Entities.Cources
{
    public class Course : Auditable
    {
        public string Name { get; set; }

        public CourseType CourseType { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
