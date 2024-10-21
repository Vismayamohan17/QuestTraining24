using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Ball", "Car", "Apple", "Bat" };
            var firstOrDefault = list.FirstOrDefault(x => x.StartsWith("B"));
            Console.WriteLine(firstOrDefault);
        }
    }
}
