using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string GetString() => "Hello";
            
            Func<string, int> a = str => str.Length;

            var inputString = GetString();

            var length = a(inputString);

            Console.WriteLine($"The length of the string is: {length}");
        }
    }
}
