using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Task_2
{
    internal class Program
    {
        static Dictionary<int, Dictionary<string, object>> products = new Dictionary<int, Dictionary<string, object>>();
        static void AddProduct(int productID, string name, decimal price, int stock)
        {
            if (!products.ContainsKey(productID))
            {
                products[productID] = new Dictionary<string, object>
            {
                { "Name", name },
                { "Price", price },
                { "Stock", stock }
            };
                Console.WriteLine("Product added successfully.");
            }
            else
            {
                Console.WriteLine("Product with this ID already exists.");
            }
        }

        static void StockUpdate(int productID, int newStock)
        {
            if (products.ContainsKey(productID))
            {
                products[productID]["Stock"] = newStock;
                Console.WriteLine("Stock updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void ProductDetails(int productID)
        {
            if (products.ContainsKey(productID))
            {
                var product = products[productID];
                Console.WriteLine($"Product ID: {productID}, Name: {product["Name"]}, Price: {product["Price"]}, Stock: {product["Stock"]}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static List<int> LowStockProducts(int threshold)
        {
            List<int> lowStockProducts = new List<int>();

            foreach (var product in products)
            {
                if ((int)product.Value["Stock"] < threshold)
                {
                    lowStockProducts.Add(product.Key);
                }
            }

            return lowStockProducts;
        }

        static void Main(string[] args)
        {
            AddProduct(101, "Laptop", 999.99m, 10);
            AddProduct(102, "Smartphone", 499.99m, 5);
            AddProduct(103, "Headphones", 79.99m, 2);

            ProductDetails(101);

            StockUpdate(103, 10);

            List<int> lowStockProducts = LowStockProducts(5);
            Console.WriteLine("Low Stock Products:");
            foreach (int id in lowStockProducts)
            {
                Console.WriteLine($"Product ID: {id}");
            }
        }
    }

}