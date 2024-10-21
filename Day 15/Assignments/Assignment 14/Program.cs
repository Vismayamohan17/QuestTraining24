using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> numbers = new List<float>() { 1.2f, 3.4f, 7.8f, 4.5f, 5.6f };
            var average = numbers.Average();
            Console.WriteLine(average);
        }
    }
}
