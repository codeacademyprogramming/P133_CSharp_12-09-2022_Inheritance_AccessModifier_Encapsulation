using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class Product
    {
        public string Name;
        public double Price;
        public string Code;

        public Product(string name)
        {
            Name = name;
        }

        public Product(string name, double price) : this(name)
        {
            Price = price;
        }
    }
}
