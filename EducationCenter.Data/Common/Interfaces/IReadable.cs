using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Data.Common.Interfaces
{
    public interface IReadable<T>
    {
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null);
    }
}
