using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Student : Human
    {
        public Student(string name) : base(name)
        {
            ShowInfo();

            Console.WriteLine(Age);
        }
    }
}
