using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> printSum = (a, b) => Console.WriteLine($"The sum is: {a + b}");

            printSum(10, 2);
        }
    }
}
