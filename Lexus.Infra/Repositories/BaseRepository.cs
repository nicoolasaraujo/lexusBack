using Lexus.Core.Interfaces.Repositories;
using Lexus.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lexus.Infra.Repositories
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        public DbSet<T> dbSet;
        public LexusContext context;
        public IUnitOfWork UnitOfWork => this.context;

        public BaseRepository(LexusContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<T>();
        }

        public void Add(T entity)
        {
            this.dbSet.Add(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return await this.dbSet.Where(predicate).AsNoTracking().ToListAsync();
        }

        public async Task<T> GetFirstByCondition(Expression<Func<T, bool>> predicate)
        {
            return await this.dbSet.Where(predicate).AsNoTracking().FirstOrDefaultAsync();
        }

        public void Remove(T entity)
        {
            this.dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            this.dbSet.Update(entity);
        }
    }
}
