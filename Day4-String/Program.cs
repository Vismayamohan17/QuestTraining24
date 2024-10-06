using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Join method - method to concatenate strings with a specified delimiter
            var res = "";
            res = string.Join(", ", "Hello", "World");
            Console.WriteLine(res);

            var arr = new string[] { "Hi", "World" };
            res = string.Join(", ", arr);
            Console.WriteLine(res);

            // Concat method - concatenate various types of values into a single string
            res = string.Concat("1", "2", 3, 10.5, true);
            Console.WriteLine(res);

            var concatArray = new string[] { "Hello", "From", "C#" };
            res = string.Concat(concatArray);

            // Format method - create formatted strings by inserting values into placeholders.
            res = string.Format("{0} {1} {2}", "Hello", "From", "C#");
            Console.WriteLine(res);

            res = string.Format("{0} {1} {2} and {2}", "Hello", "From", "C#", "C++");
            Console.WriteLine(res);

            var formatArr = new string[] { "Hello", "From", "C#" };
            res = string.Format("{0} {1} {2}", formatArr);
            Console.WriteLine(res);

            // concatenating multiple strings using the + operator
            res = "Hello " + "From " + "C#";
            Console.WriteLine(res);

            //  create a formatted string that incorporates the value of the variable 
            var language = "C#";
            res = $"Hello from {language}";

            Console.WriteLine("---------------");

            // creating an instance of the StringBuilder class
            var largeArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sb = new StringBuilder();

            //To add multiple lines of text
            sb.AppendLine("Line 1");
            sb.AppendLine("Line 2");

            //to add strings without adding a newline character
            sb.Append("No New Line");
            sb.Append("No New Line");
            sb.AppendLine();

            // to format a string and append it to the StringBuilder instance.
            sb.AppendFormat("My name is {0} {1}", "Vismaya", "Mohan");
            sb.AppendLine();

            //To iterate over an array and appending each item to a StringBuilder instance using the AppendFormat method.
            foreach (var item in largeArr)
            {
                sb.AppendFormat("{0}", item);
            }
            // converting the contents of a StringBuilder instance to a string.
            res = sb.ToString();

            Console.WriteLine(res);
        }
    }
    }
}
