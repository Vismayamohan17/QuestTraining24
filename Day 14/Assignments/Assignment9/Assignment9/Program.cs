using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
            static void WelcomeMessage(string message) => Console.WriteLine(message);
            static void Main(string[] args)
            {
                Action<string> wm = WelcomeMessage;
                wm("Hello!");
            }
    }
}
