using DAY21.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY21.Task2
{
    internal interface IStore
    {
        Product[] Products { get; }
        public int ProductLimit => 4;
        public double TotalIncome { get; }

        public void AddProduct(Product product);
        
        public bool SellProduct(string name);


    }
}

