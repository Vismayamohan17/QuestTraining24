using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, -4, -10, 6, 8 };
            var result = numbers.All(x => x > 0);
           Console.WriteLine(result);
        }
    }
}
