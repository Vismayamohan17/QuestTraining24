using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Shape
    {
        public virtual void Area(int l, int b) => System.Console.WriteLine(l * b);
        public virtual void Area(int r) => System.Console.WriteLine(3.14 * r * r);
    }

    class Rectangle : Shape
    {
        public override void Area(int l, int b)
        {
            base.Area(l, b);
        }
    }

    class Circle : Shape
    {
        public override void Area(int r)
        {
            base.Area((int)r);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle();
            r.Area(2, 4);
            var c = new Circle();
            c.Area(3);
        }
    }
}
















