using EducationSystem.Data.DbContexts;
using EducationSystem.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EducationSystem.Data.Repositories
{
#pragma warning disable
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AppDbContext context;
        internal DbSet<T> dbSet;

        public GenericRepository(AppDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public virtual async Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null ? dbSet : dbSet.Where(predicate);
        }

        public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task FindByIdAsync(long id) => await dbSet.FindAsync(id);

        public virtual async Task<T> AddAsync(T entity)
        {
            var entry = await dbSet.AddAsync(entity);

            return entry.Entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            return dbSet.Update(entity).Entity;
        }

        public virtual async Task DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entityies = await WhereAsync(predicate);

            dbSet.RemoveRange(entityies);
        }

        public virtual async Task DeleteByIdAsync(long id)
        {
            var entity = await dbSet.FindAsync(id);

            dbSet.Remove(entity);
        }
    }
}
