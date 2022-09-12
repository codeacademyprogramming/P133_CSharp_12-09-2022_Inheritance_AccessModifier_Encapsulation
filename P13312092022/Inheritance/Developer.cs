using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Developer : Student
    {
        public string Experiance;

        public Developer(string name, string surname) : base(name, surname)
        {

        }
    }
}
