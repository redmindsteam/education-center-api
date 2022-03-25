using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repasitories
{
    public class EmployeeRepasitory
        : GenericRepository<Employee>, IEmployeeRepasitory
    {
        public EmployeeRepasitory(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
