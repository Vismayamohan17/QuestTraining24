using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Program
    {
        static string Sum(int x, int y) => (x + y).ToString();
        static void Main(string[] args)
        {
            Func<int, int, string> s = Sum;

            var res = s(1, 2);
            Console.WriteLine(res);
        }
    }
}
