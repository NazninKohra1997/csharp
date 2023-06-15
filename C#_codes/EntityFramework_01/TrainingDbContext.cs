using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_01
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;
        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-GDUH6RD\\SQLEXPRESS ; Database=1st_database; Trusted_Connection=True";
            _migrationAssembly = Assembly.GetExecutingAssembly().GetName().Name;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, (x) => x.MigrationsAssembly(_migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Number> Numbers { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}