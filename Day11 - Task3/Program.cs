using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11___Task3
{
    class Calculator
    {
        private int number1;
        private int number2;

        public void ADD()
        {
            Console.WriteLine(number1 + number2);
        }
        public void SUB()
        {
            Console.WriteLine(number1 - number2);
        }
        public void MUL()
        {
            Console.WriteLine(number1 * number2);
        }
        public void DIV()
        {
            Console.WriteLine(number1 / number2);
        }

        public void Run()
        {
            Console.WriteLine("Enter number1:");
             number1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            number2 = Convert.ToInt32(Console.ReadLine());

            ADD();
            SUB();
            MUL();
            DIV();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
          
            while (true)
            {
                calculator.Run();
            }
        }
    }
}
