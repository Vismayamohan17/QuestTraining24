using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting the calculator.");
                    break;
                }

                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = 0;

                switch (choice)
                {
                    case "1":
                        result = Add(num1, num2);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = Subtract(num1, num2);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = Multiply(num1, num2);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            result = Divide(num1, num2);
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid operation.");
                        break;
                }

                Console.WriteLine(); 
            }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
