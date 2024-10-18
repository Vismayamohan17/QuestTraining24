using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    abstract class Vehicle
    {
        public abstract void Drive(int speed);
    }
    class Car : Vehicle
    {
        public override void Drive(int speed)
        {
            System.Console.WriteLine($"Speed is {speed}km/hr");
        }

    }
    class Bicycle : Vehicle
    {
        public override void Drive(int speed)
        {
            System.Console.WriteLine($"Speed is {speed}km/hr");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Car();
            c.Drive(80);
            var b = new Bicycle();
            b.Drive(30);
        }
    }

}
