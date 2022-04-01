using System.Threading.Tasks;

namespace EducationCenter.Data.Common.Interfaces
{
    public interface ISearchable<T>
    {
        public Task<T> FindAsync(int id);
    }
}
