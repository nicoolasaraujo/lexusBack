using Lexus.Core.Interfaces.Repositories;
using Lexus.Core.Models;
using Lexus.Infra.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lexus.Infra.Context
{
    public class LexusContext : DbContext, IUnitOfWork
    {
        public DbSet<User> Users { get; set; }

        public LexusContext(DbContextOptions<LexusContext> options) :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TeacherMap());
        }

        public void BeginTransaction()
        {
            this.Database.BeginTransactionAsync();
        }

        public void Rollback()
        {
            this.Database.CommitTransaction();
        }

        public async Task<bool> Commit()
        {
            return await this.SaveChangesAsync() > 0 ;
        }
    }
}
