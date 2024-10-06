using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Functions
{
    internal class Program
    {
        //static method that prints a greeting message to the console.
        static void Greet()
        {
            Console.WriteLine("Hello");
        }

        //static method that takes a string parameter and prints a greeting message that includes the provided name.
        static void GreetByName(string firstName)
        {
            Console.WriteLine("Hello " + firstName);
        }
        //Accepting 2 parameters
        static void GreetByName(string firstName, string lastName)
        {
            Console.WriteLine("Hello " + firstName + " " + lastName);
        }

        //take two integers as parameters and return their sum. 
        static int Add(int a, int b)
        {
            return a + b;
        }

        //
        static int Add(short a, int b)
        {
            return a + b;
        }

        static void SingleLineAdd(int a, int b) => Console.WriteLine(a + b);

        static int SignleLineAddWithReturn(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Greet();
            GreetByName("John");
            GreetByName("John", "Doe");
            int result = Add(1, 2);
            Console.WriteLine(result);

            SingleLineAdd(1, 2);
            Console.WriteLine(SignleLineAddWithReturn(1, 2));
        }
    }
}
