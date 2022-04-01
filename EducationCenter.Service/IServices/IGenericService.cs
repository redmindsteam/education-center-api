using EducationCenter.Service.Common.Interfaces;

namespace EducationCenter.Service.IServices
{
    public interface IGenericService<TModel, TDTO> 
        : ICreateableService<TModel, TDTO>,
          IUpdateableService<TModel,TDTO>,
          IReadCollectionableService<TModel>,
          IReadableService<TModel>,
          IDeleteableService<TModel>
    {
    }
}
