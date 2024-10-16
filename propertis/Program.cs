using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertis
{
    internal class Program
    {
        static void Main()
        {
            var s = new Student
            {
                Name = "Alpha",
                Age = 200
            };
            System.Console.WriteLine(s.Name);
            System.Console.WriteLine(s.Age);
        }
    }
}
