using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_array_resizing
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] Array = new int[] {1,2,3,4,5};

                int newSize = 8;
                int[] newArray = new int[newSize];

                for (int i = 0; i < Array.Length && i < newSize; i++)
                {
                    newArray[i] = Array[i];
                }
                Console.WriteLine("Array after resizing:");
                foreach (var item in newArray)
                {
                    Console.Write(item + " ");
                }
        }

    }
}
