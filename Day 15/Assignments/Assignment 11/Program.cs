using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 20, 25, 32, 52, 57, 80, 95 };
            var result = list.Where(x => x > 50);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
