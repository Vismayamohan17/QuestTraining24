using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 1, 7, 10, 12, 14, 16 };
            var result = numbers.Where(x => x > 10);
            var count = result.Count();
            Console.WriteLine(count);
        }
    }
}
