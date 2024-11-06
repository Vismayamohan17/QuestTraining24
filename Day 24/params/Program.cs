using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    internal class Program
    {
        static void Add(int i,int j,params int[] data)
        {
            Console.WriteLine(data.Sum() + i + j);
        }
        static void Main(string[] args)
        {
            Add(3,5);
            Add(3, 4);
            Add(4,5, 6);
        }
    }
}
