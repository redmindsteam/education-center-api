using EducationSystem.Domain.Entities.Common;
using EducationSystem.Domain.Entities.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystem.Domain.Entities.Cources
{
    public class CouseSubject : Auditable
    {
        public long CourseId { get; set; }
        public virtual Course Course { get; set; }

        public long SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
