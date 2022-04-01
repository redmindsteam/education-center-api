using EducationCenter.Domain.Common;
using System.Threading.Tasks;

namespace EducationCenter.Service.Common.Interfaces
{
    public interface ICreateableService<TModel, TDTO>
    {
        Task<BaseResponse<TModel>> CreateAsync(TDTO dto);
    }
}
