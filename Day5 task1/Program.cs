using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter your birth month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter your birth day: ");
            int day = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Now;
            DateTime birthDate = new DateTime(year, month, day);

            int age = today.Year - birthDate.Year;

            Console.WriteLine("Your age is: " + age);
        }
    }
}

