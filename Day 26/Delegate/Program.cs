using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate int Operation(int a, int b);
        static int Calculate(int x, int y, Operation operation)
        {
            return operation(x, y);
        }

        static void Main()
        {

            int sum = Calculate(10, 5, (a, b) => a + b);
            Console.WriteLine("Addition: " + sum);  

            int product = Calculate(10, 5, (a, b) => a * b);
            Console.WriteLine("Multiplication: " + product);
        }
    }
}
