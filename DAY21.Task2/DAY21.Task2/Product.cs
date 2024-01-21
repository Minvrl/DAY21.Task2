using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY21.Task2
{
    internal class Product
    {
        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;  
            Count = count;  
        }
        public string Name;
        public double Price;
        public int Count;
    }
}
