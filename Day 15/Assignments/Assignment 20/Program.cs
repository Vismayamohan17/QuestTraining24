using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "Amal", "Arya", "John", "Diana" };
            var marks = new List<int> { 65, 70, 100, 90 };
            var zip = names.Zip(marks, (name, mark) => { return new { name, mark }; });
            foreach (var name in zip)
            {
                Console.WriteLine(name);
            }
        }
    }
}
