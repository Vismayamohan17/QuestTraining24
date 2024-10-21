using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 5, 6, 10, 3, 7 };
            var max = numbers.Max();
            Console.WriteLine(max);
        }
    }
}
