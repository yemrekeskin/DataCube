using Microsoft.EntityFrameworkCore;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class SchoolContext 
        : DbContext
    {
        public SchoolContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            //Property Configurations
            modelBuilder.Entity<Student>()
                    .Property(s => s.Id)
                    .HasColumnName("StudentId")
                    .HasDefaultValue(0)
                    .IsRequired();

            //Separate method calls
            modelBuilder.Entity<Student>().Property(s => s.Id).HasColumnName("StudentId");
            modelBuilder.Entity<Student>().Property(s => s.Id).HasDefaultValue(0);
            modelBuilder.Entity<Student>().Property(s => s.Id).IsRequired();

        }

        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
