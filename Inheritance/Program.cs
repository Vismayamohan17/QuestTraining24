using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
    {
        public string DataA { get; set; }
        public void MethodA() => Console.WriteLine("From Class A");
    }

    class B : A
    {
        public int DataB { get; set; }
        public void MethodB()
        {
            Console.WriteLine("From Class B");
            base.MethodA();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            b.MethodA();
            b.MethodB();
        }
    }
}
