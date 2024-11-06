using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringoccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "Hello world.This is a hello world program";
            var wordCount = new Dictionary<string, int>();
            string word = "";

            foreach (char c in input.ToLower())
            {
                if (char.IsLetterOrDigit(c)) 
                {
                    word += c;
                }
                else if (word != "") 
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++; 
                    }
                    else
                    {
                        wordCount[word] = 1; 
                    }
                    word = ""; 
                }
            }

            if (word != "")
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
