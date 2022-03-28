using EducationCenter.Data.Common.Interfaces;

namespace EducationCenter.Data.IRepasitories
{
    public interface IGenericRepository<T> : 
        ICreatable<T>, IReadable<T>, IUpdateable<T>, IDeleteable<T> 
    {
        
    }
}
