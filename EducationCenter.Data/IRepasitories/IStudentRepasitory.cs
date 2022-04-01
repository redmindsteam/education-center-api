using EducationCenter.Domain.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationCenter.Data.IRepasitories
{
    public interface IStudentRepasitory : IGenericRepository<Student>
    {
        Task<IEnumerable<Student>> GetStudentGroupsAsync(int id);
    }
}
