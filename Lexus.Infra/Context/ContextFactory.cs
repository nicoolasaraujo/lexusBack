using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lexus.Infra.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<LexusContext>
    {
        private IConfiguration configuration;

        public LexusContext CreateDbContext(string[] args)
        {
            this.configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<LexusContext>();
            builder.UseMySql(configuration.GetConnectionString("DefaultConnection"));

            return new LexusContext(builder.Options);
        }
    }
}
