using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Alpha";
            p.Email = "alpha@gmial.com";

            p.Addresses = new List<Address>();
            p.Addresses.Add(new Address { AddressType = "Home", Line1 = "Church Street", Line2 = "Bangalore", Pincode = "678765" });
            p.Addresses.Add(new Address { AddressType = "Office", Line1 = "Mount Road", Line2 = "Chennai", Pincode = "987665" });

            // System.Console.WriteLine(p.Name);
            // System.Console.WriteLine(p.Email);
            // System.Console.WriteLine(p.Addresses);
        }
    }
}
