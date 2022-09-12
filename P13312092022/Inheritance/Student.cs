using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Student : Human
    {
        public double Grade;
        public string Education;

        public Student(string name, string surname) : base(name)
        {
            SurName = surname;
        }
    }
}
