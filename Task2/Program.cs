using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cs = new CollegeStudent
            {
                Name = "Vismaya",
                Email = "vismaya123@gmail.com",
                CollegeName = "abc"
            };
            var ss = new SchoolStudent
            {
                Name = "Lakshya",
                Email = "lakshya123@gmail.com",
                SchoolName = "xyz"
            };
            Console.WriteLine(cs);
            Console.WriteLine(ss);

        }
    }
}
