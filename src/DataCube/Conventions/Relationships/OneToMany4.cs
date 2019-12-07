﻿using System;
using System.Collections.Generic;
using System.Text;

namespace School.OneToMany4
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // nullable types
        //public int? GradeId { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }

    public class Grade
    {
        public int Id { get; set; } 
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
