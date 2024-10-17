using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }

        static Employee()
        {
            CompanyName = "Microsoft";
        }
        public Employee(string name) => Name = name;

        public override string ToString() => Name  + " " + CompanyName;
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Name:"+Employee.CompanyName);
            var el = new Employee("Joe");
            Console.WriteLine(el);
        }
    }
}
