using System.Threading.Tasks;

namespace EducationCenter.Data.Common.Interfaces
{
    public interface IUpdateable<T> 
    {
        Task<T> UpdateAsync(T entity);
    }
}
