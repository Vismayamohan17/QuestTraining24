using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5___Word_replacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentence:");
            string text = Console.ReadLine();
            Console.Write("Enter the word to replace:");
            string word = Console.ReadLine();
            Console.Write("Enter the word need to replace with old one:");
            string replace = Console.ReadLine();
            string newSentence = text.Replace(word, replace);

            Console.WriteLine("Updated Sentence: " + newSentence);
        }
    }
}
