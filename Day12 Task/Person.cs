using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Task
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

    }
    public class Address
    {
        public string AddressType { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Pincode { get; set; }

    }
}
