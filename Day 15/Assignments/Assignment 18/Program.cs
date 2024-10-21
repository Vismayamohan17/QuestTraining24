using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{
    internal class Program
    {
        class Products
        {
            public string Product { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            var products = new List<Products>
            {
                new Products {Product = "Book",Price = 120 },
                new Products { Product = "Pen", Price = 10 },
                new Products { Product = "Scale", Price = 20 },
                new Products { Product = "Eraser", Price = 8 },
                new Products {Product = "Sharpner", Price = 5 }
            };
            var g100 = products.Where(x => x.Price > 100).OrderBy(x => x.Price);
            foreach (var product in g100)
            {
                Console.WriteLine($"Product:{product.Product},Price:{product.Price}");
            }
        }
    }
}
