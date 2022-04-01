using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repositories
{
    public class RoomRepository
        : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
