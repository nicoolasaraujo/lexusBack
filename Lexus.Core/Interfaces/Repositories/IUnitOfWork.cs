using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lexus.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        public void BeginTransaction();
        public void Rollback();
        public Task<bool> Commit();
    }
}
