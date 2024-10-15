using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Salary;

        public void TotalSalary()
        {
            Console.WriteLine($"Total Salary : {Salary * 12}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Employee employee1 = new Employee();
                employee1.FirstName = "John";
                employee1.LastName = "Mathew";
                employee1.Salary = 50000;

                Employee employee2 = new Employee();
                employee2.FirstName = "Alice";
                employee2.LastName = "Thomas";
                employee2.Salary = 40000;

                employee1.TotalSalary();
                employee2.TotalSalary();
        }
    }
}
