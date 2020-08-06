using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lexus.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<T>
    {
        IUnitOfWork UnitOfWork { get; }
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> predicate);
        Task<T> GetFirstByCondition(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
