using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Apple", "Ant", "Bat", "Ball", "Mango" };
            var groups = list.GroupBy(x => x.Length);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }

            foreach (var item in groups)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }
}
