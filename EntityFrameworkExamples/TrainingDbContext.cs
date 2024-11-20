using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString = "Server=.;Database=CSharpB18Irfan;User Id=csharpirfan;Password=123456;Trust Server Certificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEnrollment>().HasKey((e) => new { e.CourseId, e.StudentId});
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseEnrollment>().ToTable("CourseEnrollments");

            modelBuilder.Entity<Course>().Property(e => e.Title).HasMaxLength(250);

            modelBuilder.Entity<Course>().HasMany( e => e.Topics)
                                         .WithOne(e => e.Course)
                                         .HasForeignKey(e => e.CourseId);
            modelBuilder.Entity<CourseEnrollment>().HasOne(e => e.Course)
                                                  .WithMany(e => e.CourseStudents)
                                                  .HasForeignKey(e => e.CourseId);
            modelBuilder.Entity<Student>().HasMany(e => e.MyCourses)
                                          .WithOne(e => e.Student)
                                          .HasForeignKey(e => e.StudentId);   
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students{ get; set; }
    }
}
