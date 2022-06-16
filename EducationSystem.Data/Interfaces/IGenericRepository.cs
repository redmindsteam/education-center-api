using System.Linq.Expressions;

namespace EducationSystem.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> predicate = null);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        Task FindByIdAsync(long id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(Expression<Func<T, bool>> predicate);
        Task DeleteByIdAsync(long id);
    }
}
