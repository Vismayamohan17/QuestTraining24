using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Task2
{
    internal class SmartPhone
    {
        public string Name;
        public string Brand;
        public List<int> AvailableMemory;

        public void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Brand : " +Brand);
            Console.WriteLine("AvailableMemory : "+string.Join(", ",AvailableMemory));

        }
    }
}
