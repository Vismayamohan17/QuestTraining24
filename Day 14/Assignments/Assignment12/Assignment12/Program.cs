using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class Program
    {
        static bool StartsWithA(string str)
        {
            return str.StartsWith("A");
        }
        static void Main(string[] args)
        {
           Predicate<string> startsWithA = StartsWithA;
           string text = "Animal";
           bool result = startsWithA(text);
           Console.WriteLine($"'{text}' starts with 'A': {result}");
        }
    }
}
