using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5._5_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string,string> d = new Dictionary<string,string>();
            var d = new Dictionary<string, string>();

            //Adding values
            d.Add("First Name", "John");
            d.Add("Last Name", "Doe");

            //Accesing a value
            Console.WriteLine(d["First Name"]);

            //Updating a value
            d["First Name"] = "Jane";
            Console.WriteLine(d["First Name"]);

            //Remove a value
            d.Remove("Last Name");

            d.Add("Age", "22");

            //Check if a akey exists.
            if(d.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exists.");
            }
            else
            {
                Console.WriteLine("Age does not exist.");
            }

            //Looping a dictionary
            foreach(var item in d)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
