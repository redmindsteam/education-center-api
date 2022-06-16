namespace EducationSystem.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
