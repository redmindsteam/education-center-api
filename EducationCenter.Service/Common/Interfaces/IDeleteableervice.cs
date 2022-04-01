using EducationCenter.Domain.Common;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.Common.Interfaces
{
    public interface IDeleteableService<TModel>
    {
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<TModel, bool>> expression);
    }
}
