using EducationCenter.Domain.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationCenter.Data.IRepositories
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<IEnumerable<Student>> GetStudentGroupsAsync(int id);
    }
}
