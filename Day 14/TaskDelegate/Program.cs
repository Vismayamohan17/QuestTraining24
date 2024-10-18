using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDelegate
{
    internal class Program
    {
        delegate void TaskDelegate();
        static void StartTimer(int seconds, TaskDelegate task)
        {
            Console.WriteLine("Timer Started");
            Thread.Sleep(seconds + 1000);
            task();
        }
        static void GreetAfterTenSeconds()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            StartTimer(10, GreetAfterTenSeconds);
        }
    }
}
