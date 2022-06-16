using EducationSystem.Data.DbContexts;
using EducationSystem.Data.Interfaces;

namespace EducationSystem.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Repositories
        /// </summary>
        // public IUserRepository Users { get; private set; }

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;

            // Initialize repositories
            // Users = new UserRepository(context);

        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
