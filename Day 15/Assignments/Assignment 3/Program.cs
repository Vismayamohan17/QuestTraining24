using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.OrderByDescending(x => x);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
