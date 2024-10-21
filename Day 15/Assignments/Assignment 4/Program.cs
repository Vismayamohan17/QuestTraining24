using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var squares = numbers.Select(x => x * x) .ToList();
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }
        }
    }
}
