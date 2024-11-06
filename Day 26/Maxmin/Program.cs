using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world This is a hello world program";
            var result = text.ToLower()
                .Split(' ')
                .GroupBy(x => x);

            var mostOccurred = result.OrderByDescending(w => w.Count()).First();
            var leastOccurred = result.OrderBy(w => w.Count()).First();


            Console.WriteLine($"Most occurred word: {mostOccurred.Key} (Count: {mostOccurred.Count()})");
            Console.WriteLine($"Least occurred word: {leastOccurred.Key} (Count: {leastOccurred.Count()})");
        }
    }
}
