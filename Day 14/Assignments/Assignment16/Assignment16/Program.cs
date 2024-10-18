using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    class Employee
    {
        public virtual double CalculateBonus(double salary)
        {
            return salary * 0.1;
        }
    }

    class Manager : Employee
    {
        public override double CalculateBonus(double salary)
        {
            return salary * 0.2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Manager manager = new Manager();

            double employeeSalary = 50000;
            double managerSalary = 70000;

            Console.WriteLine($"Employee Bonus: {employee.CalculateBonus(employeeSalary)}");
            Console.WriteLine($"Manager Bonus: {manager.CalculateBonus(managerSalary)}");
        }
    }
}
