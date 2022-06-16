using EducationSystem.Domain.Entities.Common;
using EducationSystem.Domain.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
