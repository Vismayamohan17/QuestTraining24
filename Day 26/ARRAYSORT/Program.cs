using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine($"Reversed string: {reversed}");
        }

        static string ReverseString(string str)
        {
            char[] reversedArray = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            reversedArray[i] = str[str.Length - 1 - i];

            return new string(reversedArray);
        }
    }

}
