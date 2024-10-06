using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_Word_checking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter a word to search for: ");
            string word = Console.ReadLine();

            bool isPresent = sentence.Contains(word);
            if (isPresent)
            {
                Console.WriteLine($"The word '{word}' is present in the sentence.");
            }
            else
            {
                Console.WriteLine($"The word '{word}' is not present in the sentence.");
            }
        }
    }
}
