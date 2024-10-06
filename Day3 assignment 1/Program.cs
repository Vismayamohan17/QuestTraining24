using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_assignment_1
{
    internal class Program
    {
        static void SwapArray(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int temp = arr[0];
                arr[0] = arr[1];
                arr[1] = temp;
            }

            if (n > 3)
            {
                int temp = arr[n - 2];
                arr[n - 2] = arr[n - 1];
                arr[n - 1] = temp;
            }
        }

        static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            SwapArray(arr);

            Console.WriteLine("Modified Array: " + string.Join(",", arr));
        }
    }
}
