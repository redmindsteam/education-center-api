using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Models.Entities;

namespace EducationCenter.Data.Repositories
{
    public class EmployeeRepository
        : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
