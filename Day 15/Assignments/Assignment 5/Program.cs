using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = list.Where(x => x % 2 == 0);
            var result = evenNumbers.Select(x => x * x).ToList();
            foreach ( var x in result )
            {
                Console.WriteLine(x);   
            }

        }
    }
}
