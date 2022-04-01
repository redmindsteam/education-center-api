using EducationCenter.Domain.Common;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.Common.Interfaces
{
    public interface IReadableService<TModel>
    {
        Task<BaseResponse<TModel>> GetAsync(Expression<Func<TModel, bool>> expression);
    }
}
