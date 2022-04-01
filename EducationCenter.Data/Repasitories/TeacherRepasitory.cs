using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repasitories
{
    public class TeacherRepasitory
        : GenericRepository<Teacher>, ITeacherRepasitory
    {
        public TeacherRepasitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
