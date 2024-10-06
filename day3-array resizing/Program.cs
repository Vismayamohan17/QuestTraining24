using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_array_resizing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            Array.Resize(ref arr, arr.Length * 2);
            arr[4] = 6;
            arr[5] = 7;
            arr[6] = 8;
            arr[7] = 9;
            arr[8] = 10;
            Console.WriteLine(arr.Length);
        }
    }
}
