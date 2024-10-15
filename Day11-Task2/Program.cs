using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone1 = new SmartPhone();
            phone1.Name = " iPhone 15";
            phone1.Brand = "Apple";
            phone1.AvailableMemory = new List<int>() { 128, 256, 512 };

            SmartPhone phone2 = new SmartPhone();
            phone2.Name = "Samsung Galaxy S23";
            phone2.Brand = "Samsung";
            phone2.AvailableMemory = new List<int>() { 128, 256, 512 };

            phone1.Display();
            phone2.Display();
        }
    }
}
