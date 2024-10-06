using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }

        static bool IsPalindrome(string text)
        {
            int length = text.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (text[i] != text[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
  
