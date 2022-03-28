using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Data.Common.Interfaces
{
    public interface IDeleteable<T> 
    {
        Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);
    }
}
