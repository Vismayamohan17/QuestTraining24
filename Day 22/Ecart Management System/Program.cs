using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart_Management_System
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Item(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public decimal TotalPrice()
        {
            return Quantity * Price;
        }
    }
    public class Cart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(string name, int quantity)
        {
            var item = items.FirstOrDefault(i => i.Name == name);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public void RemoveItem(string name)
        {
            items.RemoveAll(i => i.Name == name);
        }

        public decimal CalculateTotal()
        {
            return items.Sum(item => item.TotalPrice());
        }

        public decimal ApplyDiscount(IDiscountStrategy discountStrategy)
        {
            return discountStrategy.ApplyDiscount(CalculateTotal());
        }

        public List<Item> GetItems()
        {
            return items;
        }
    }
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal total);
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal ApplyDiscount(decimal total)
        {
            return total - (total * (percentage / 100));
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Cart cart = new Cart();
            cart.AddItem(new Item("Laptop", 1, 1000));
            cart.AddItem(new Item("Headphones", 2, 150));

            IDiscountStrategy percentageDiscount = new PercentageDiscount(10);
            decimal totalAfterPercentageDiscount = cart.ApplyDiscount(percentageDiscount);
            Console.WriteLine($"Total after 10% discount: {totalAfterPercentageDiscount}");
        }
    }
}
