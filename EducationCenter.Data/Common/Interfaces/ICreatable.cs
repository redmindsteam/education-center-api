using System.Threading.Tasks;

namespace EducationCenter.Data.Common.Interfaces
{
    public interface ICreatable<T>
    {
        Task<T> CreateAsync(T entity);
    }
}
