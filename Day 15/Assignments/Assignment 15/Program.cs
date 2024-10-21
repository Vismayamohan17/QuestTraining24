using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 4, 2, 5, 6, 5, 1 };
            var result = numbers.Distinct();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
