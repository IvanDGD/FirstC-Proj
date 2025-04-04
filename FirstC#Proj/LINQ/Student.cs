﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.LINQ
{
    internal class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string University;

        public Student(string firstName, string lastName, int age, string university)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            University = university;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}, University: {University}";
        }
    }
}
