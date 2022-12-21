using EntityFrameworkExample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;

        public TrainingDbContext()
        {
            _connectionString = @"Server = DESKTOP-6CHMV3E\SQLEXPRESS; Database = CSharpB12; User Id=CSharp; Password=1615037;";
            _migrationAssembly = Assembly.GetExecutingAssembly().GetName().Name;
        }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, (x) => x.MigrationsAssembly(_migrationAssembly));
            }

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<CourseSchedule>().ToTable("CourseSchedules");
            modelBuilder.Entity<CourseEnrollment>().ToTable("CourseEnrollments");
            modelBuilder.Entity<CourseEnrollment>().HasKey((x) => new {x.CourseId,x.UserId});
             base.OnModelCreating(modelBuilder);
        }

        
         public DbSet<User> Users{get;set;}
         public DbSet<Course> Courses{get;set;}
         public DbSet<CourseSchedule> CourseSchedules{get; set;}
    }
}