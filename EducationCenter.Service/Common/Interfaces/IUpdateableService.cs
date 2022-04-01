using EducationCenter.Domain.Common;
using System.Threading.Tasks;

namespace EducationCenter.Service.Common.Interfaces
{
    public interface IUpdateableService<TModel, TDTO>
    {
        Task<BaseResponse<TModel>> UpdateAsync(int id, TDTO dto);
    }
}
