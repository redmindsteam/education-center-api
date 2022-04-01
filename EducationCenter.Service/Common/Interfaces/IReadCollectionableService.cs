using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.Common.Interfaces
{
    public interface IReadCollectionableService<TModel>
    {
        Task<BaseResponse<IEnumerable<TModel>>> GetAllAsync(PaginationParams @params,
            Expression<Func<TModel, bool>> expression = null);
    }
}
