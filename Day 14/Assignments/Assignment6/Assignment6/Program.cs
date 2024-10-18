using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public delegate void PrintMessage(string Message);
    class Program
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            var p = new PrintMessage(DisplayMessage);
            p("Hello");
        }
    }
}
