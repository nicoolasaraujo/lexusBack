using Lexus.Core.Models;
using Lexus.Infra.Map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Infra.Context
{
    public class LexusContext : DbContext
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
    }
}
