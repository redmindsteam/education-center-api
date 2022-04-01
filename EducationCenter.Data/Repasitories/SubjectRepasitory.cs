using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repasitories
{
    public class SubjectRepasitory
        : GenericRepository<Subject>, ISubjectRepasitory
    {
        public SubjectRepasitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
