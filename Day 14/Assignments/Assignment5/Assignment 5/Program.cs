using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
  public delegate int Operation(int a, int b);
  public class Calculator
  {
     public int Add(int a, int b)
     {
        return a + b;
     }
     public int Multiply(int a, int b)
     {
        return a * b;
     }
  }

  class Program
  {
     static void Main(string[] args)
     {
         var c = new Calculator();
         var a = new Operation(c.Add);
         var m = new Operation(c.Multiply);
         int sum = a(5, 3);
         int product = m(5, 3);
         Console.WriteLine($"Sum: {sum}");
         Console.WriteLine($"Product: {product}");
     }
  }

}
