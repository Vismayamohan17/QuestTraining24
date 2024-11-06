using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_delegate
{
    internal class Program
    {
        delegate void GreetingDelegate(string message);
        static void Greet(string message)
        {
            Console.WriteLine("Greeting: " + message);
        }
        static void Farewell(string message)
        {
            Console.WriteLine("Farewell: " + message);
        }

        static void Main()
        {
            GreetingDelegate greetingDelegate;

            greetingDelegate = Greet;          
            greetingDelegate += Farewell;     

            greetingDelegate("Hello, everyone!");

            greetingDelegate -= Farewell;

            greetingDelegate("Goodbye, everyone!");
        }
    }
}
