﻿using Microsoft.EntityFrameworkCore;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class SchoolContext 
        : DbContext
    {
        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; } 
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolTest_DB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                    .Property<DateTime>("LastUpdated");

            //Write Fluent API configurations here

            //Property Configurations
            //modelBuilder.Entity<Student>()
            //        .Property(s => s.Id)
            //        .HasColumnName("StudentId")
            //        .HasDefaultValue(0)
            //        .IsRequired();

            //Separate method calls
            //modelBuilder.Entity<Student>().Property(s => s.Id).HasColumnName("StudentId");
            //modelBuilder.Entity<Student>().Property(s => s.Id).HasDefaultValue(0);
            //modelBuilder.Entity<Student>().Property(s => s.Id).IsRequired();

            base.OnModelCreating(modelBuilder);
        }       
    }
}
