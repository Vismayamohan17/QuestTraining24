using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Task4
{
    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public int TotalMark()
        {
            return Mark1 +Mark2 + Mark3;
        }

        public double AvgMark()
        {
           return ((Mark1 + Mark2 + Mark3) / 3);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student
            {
                Name = "Student1",
                Mark1 = 50,
                Mark2 = 49,
                Mark3 = 48
            };
            var s2 = new Student
            {
                Name = "Student2",
                Mark1 = 45,
                Mark2 = 30,
                Mark3 = 48
            };

            Student[] students = new Student[2];
            students[0] = s1;
            students[1] = s2;
           


            foreach(var  student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Total Marks: {student.TotalMark()}, AvgMarks: {student.AvgMark()}");

            }


        }
    }
}
