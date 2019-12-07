using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.OneToMany3
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Grade Grade { get; set; }
    }

    public class Grade
    {
        public int Id { get; set; } 
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
