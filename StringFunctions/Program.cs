using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "    Hello World    ";

            //converting to uppercase
            Console.WriteLine(text.ToUpper());

           
            //converting to lowercase
            Console.WriteLine(text.ToLower()); 

           
            //Removing whitespace from start and end
            Console.WriteLine(text.Trim());

            
            //Removing whitespace from start
            Console.WriteLine(text.TrimStart());

           
            //Removing from end
            Console.WriteLine(text.TrimEnd());

            
            //replaces the specified old character with the specified new character
            Console.WriteLine(text.Replace(" ", "-"));

            
            //removing characters from a string
            Console.WriteLine(text.Remove(0, 7));


            //To find the length of a string
            Console.WriteLine(text.Length);

            //return the length of the string after trimming the spaces
            Console.WriteLine(text.Trim().Length);

            //checks if a given substring exists within the main string and returns a boolean
            Console.WriteLine(text.Contains("Hello"));

            //checks if a string starts with a specified substring
            Console.WriteLine(text.StartsWith("    Hello"));

            ////checks if a string starts with a specified substring and allows for case-insensitive comparison
            Console.WriteLine(text.StartsWith("    hello", StringComparison.OrdinalIgnoreCase));

            //checks if a string ends with a specified substring
            Console.WriteLine(text.EndsWith("    "));

            //converts a string into an array of characters
            char[] chars = text.ToCharArray();

            //concatenate the elements of an array into a single string, separated by a specified delimiter
            Console.WriteLine(string.Join(", ", chars));

            //divide a string into an array of substrings based on a specified delimiter
            string[] words = text.Split(' ');

            //Concatenate the array elements into a single string, with a specified delimiter placed between each word.
            Console.WriteLine(string.Join(", ", words));

            //StringSplitOptions enumeration to control how the splitting is done
            string[] splits = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
    
}
