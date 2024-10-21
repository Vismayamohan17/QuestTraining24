using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Apple", "Car", "Ant", "Ball", "Aeroplane" };
            var startsWithA = list.Where(x => x.StartsWith("A"));
            foreach (var x in startsWithA)
            {
                Console.WriteLine(x);
            }
        }
    }
}
