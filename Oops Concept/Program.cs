using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    class Student
    {
        public string Name;

        public void DisplayName()
        {
            Console.Write(Name.ToUpper());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Vismaya";
            s.DisplayName();
        }
    }
}
