using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repositories
{
    public class GroupRepository
        : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
