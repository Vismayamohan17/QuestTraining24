using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even Numbers");

            var even = numbers.Where(n => n.IsEven());

            foreach (var num in even)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Odd Numbers");
            var odd = numbers.Where(n => n.IsOdd());

            foreach (var num in odd)
            {
                Console.WriteLine(num);
            }
        }
    }
}
