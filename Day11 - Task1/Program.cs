using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11___Task1
{
    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void TotalMarks()
        {
            Console.WriteLine($"Total mark is: {Mark1 + Mark2 + Mark3}");
        }
        
        public void AvgMarks()
        {
            Console.WriteLine($"Average mark is: {(Mark1 + Mark2 + Mark3)/ 3}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Arjun";
            s1.Mark1 = 50;
            s1.Mark2 = 48;
            s1.Mark3 = 35;

            Student s2 = new Student();
            s2.Name = "Arya";
            s2.Mark1 = 49;
            s2.Mark2 = 44;
            s2.Mark3 = 50;

            Console.WriteLine($"Marks of student {s1.Name}");
            s1.TotalMarks();
            s1.AvgMarks ();

            Console.WriteLine($"Marks of student {s2.Name}");
            s2.TotalMarks();
            s2.AvgMarks ();
        }
    }
}
