using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repasitories
{
    public class RoomRepasitory
        : GenericRepository<Room>, IRoomRepasitory
    {
        public RoomRepasitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
