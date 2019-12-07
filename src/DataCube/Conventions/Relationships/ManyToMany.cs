﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Conventions.ManyToMany
{
    public class Student
    {
        public int Id { get; set; }        
        public string Name { get; set; }

        public List<StudentCourse> StudentCourses { get; set; } 
    }

    public class Course
    {
        public int Id { get; set; } 
        public string CourseName { get; set; }
        public string Description { get; set; }

        public List<StudentCourse> StudentCourses { get; set; }
    }

    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
