using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repasitories
{
    public class GroupRepasitory
        : GenericRepository<Group>, IGroupRepasitory
    {
        public GroupRepasitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
