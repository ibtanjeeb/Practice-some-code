using System;
using System.Collections.Generic;
using System.Text;
using EntityFramwork.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramwork.DbContexts
{
  public class TRainingContext:DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public TRainingContext()
        {
            _connectionString = ConnectionStringReader.ConnectionString;
            _assemblyName = typeof(Program).Assembly.FullName;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if(!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
                    
            }
            base.OnConfiguring(dbContextOptionsBuilder);
        }
        public DbSet<Student> students { get; set; }


    }
}
