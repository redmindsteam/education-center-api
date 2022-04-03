using EducationCenter.Data.DbContexts;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Data.Repositories
{
    public class GenericRepository<T> 
        : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext dbContext;
        protected DbSet<T> dbSet;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            var entry = await dbSet.AddAsync(entity);

            await dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public virtual async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await dbSet.FirstOrDefaultAsync(expression);

            if (entity is null)
                return false;

            dbSet.Remove(entity);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public virtual async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            return expression is null ? dbSet : dbSet.Where(expression);
        }

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await dbSet.FirstOrDefaultAsync(expression);

            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            var entry = dbSet.Update(entity);

            await dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public virtual async Task<T> FindAsync(int id)
        {
            return await dbSet.FindAsync(id);  
        }
    }
}
