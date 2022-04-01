using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repositories
{
    public class SubjectRepository
        : GenericRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
