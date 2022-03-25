using EducationCenter.Domain.Common;
using System;

namespace EducationCenter.Domain.Models.Entities
{
    public class LessonTimeDetail : BaseEntity
    {
        public string BeginTime { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public string EndTime { get; set; }
    }
}
