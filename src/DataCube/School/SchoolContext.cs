using Microsoft.EntityFrameworkCore;
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

        }

        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
