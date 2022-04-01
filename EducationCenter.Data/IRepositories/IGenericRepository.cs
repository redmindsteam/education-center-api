using EducationCenter.Data.Common.Interfaces;

namespace EducationCenter.Data.IRepositories
{
    public interface IGenericRepository<T> 
        : ICreatable<T>, IReadable<T>, 
          IUpdateable<T>, IDeleteable<T>,
          ISearchable<T>
    {
        
    }
}
