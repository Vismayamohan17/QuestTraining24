using System;

namespace Abstract
{
    abstract class CalculatorBase
    {
        public void Add(int a, int b) => System.Console.WriteLine(a + b);
        public void Sub(int a, int b) => System.Console.WriteLine(a - b);
        public void Mul(int a, int b) => System.Console.WriteLine(a * b);
        public virtual void Div(int a, int b) => System.Console.WriteLine(a / b);
        public abstract void Power(int a, int b);
    }

    class Calculator : CalculatorBase
    {
        public override void Div(int a, int b)
        {
            if (b == 0)
            {
                System.Console.WriteLine("Divide by zero error");
                return;
            }
            base.Div(a, b);
        }

        public override void Power(int a, int b)
        {
            System.Console.WriteLine(Math.Pow(a, b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.Add(5, 10);
            calc.Div(10, 0);
            calc.Div(10, 2);
            calc.Power(2, 3);
        }
    }
}