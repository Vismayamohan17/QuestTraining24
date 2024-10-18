using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    abstract class Appliance
    {
        public abstract void TurnOn();
    }
    class Fan : Appliance
    {
        public override void TurnOn() => Console.WriteLine("The fan is on");
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = new Fan();
            f.TurnOn();
        }
    }
}
