using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            var sortedStr1 = String.Concat(str1.ToLower().OrderBy(c => c));
            var sortedStr2 = String.Concat(str2.ToLower().OrderBy(c => c));

            return sortedStr1 == sortedStr2;
        }

        static void Main()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            if (AreAnagrams(str1, str2))
                Console.WriteLine("The strings are anagrams.");
            else
                Console.WriteLine("The strings are not anagrams.");
        }
    }
}
