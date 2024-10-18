using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public interface ICalculator
    {
        void Add(int a, int b);
        void Sub(int a, int b);
    }
    public class Calculator : ICalculator
    {
        public void Add(int a, int b) => System.Console.WriteLine(a + b);
        public void Sub(int a, int b) => System.Console.WriteLine(a - b);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Calculator();
            a.Add(2, 3);
            var s = new Calculator();
            s.Sub(4, 3);
        }

    }
}
