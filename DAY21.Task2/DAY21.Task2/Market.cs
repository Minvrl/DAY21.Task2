using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DAY21.Task2
{

    internal class Market:IStore
    {
        private Product[] products = new Product[0];
        public Product[] Products => products;
        public int ProductLimit => 4;
        public double TotalIncome { get; set; }


        public void AddProduct(Product product)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == product.Name)
                {
                    Console.WriteLine("Mehsul artiq elave olunub!");
                    return; 
                }
            }

            if (products.Length >= ProductLimit)
            {
                Console.WriteLine("Mehsul limiti dolub!");
                return; 
            }

            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
            Console.WriteLine($"Mehsul sisteme elave olundu.");
        }


        public bool SellProduct(string name)
        {
            int neededIndex = -1;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name == name && products[i].Count != 0)
                {
                    neededIndex = i;
                    break; 
                }
            }
            if (neededIndex == -1)
            {
                Console.WriteLine("Mehsul tapilmadi.");
                return false;
            }
            TotalIncome += products[neededIndex].Price;

            if (products[neededIndex].Count == 1)
            {
                for (int i = neededIndex; i < Products.Length - 1; i++)
                {
                    var temp = products[i];
                    products[i] = products[i + 1];
                    products[i + 1] = temp;
                }
                Array.Resize(ref products, products.Length - 1);

            }
            else
                products[neededIndex].Count--;

            Console.WriteLine("Mehsul satildi!");
            Console.WriteLine($"Umumi gelir - {TotalIncome} man");

            return true;
        }

        public void ShowProducts()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. AD - {products[i].Name} // QIYMET - {products[i].Price} man // SAY - {products[i].Count}");
            }

        }

        public void Sellable()
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"\n{i+1}. {products[i].Name} - {products[i].Price} man");
            }
        }

    }
}
