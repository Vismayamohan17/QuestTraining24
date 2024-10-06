using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Oddeven_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write($"The number {num} is even.");
            }
            else
            {
                Console.Write($"The number {num} is odd.");
            }
        }
    }
}
