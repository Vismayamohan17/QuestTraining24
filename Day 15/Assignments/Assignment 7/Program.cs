using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "S1", "S2", "S3", "S4", "S5" };
            var marks = new List<int>() { 80, 90, 85, 40, 50 };

            var res = names
                .Zip(marks, (name, mark) => { return new { name, mark }; })
                .Where(s => s.mark > 80)
                .Select(s => s.name);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}
