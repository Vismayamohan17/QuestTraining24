using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initializing an array
            int[] numbers = new int[10];
            int[] array1 = { 1, 2, 3, 4, 5 };

            //Initializing a nullable array
            int?[] nullableArray = new int?[10];

            //Reading elements into an array
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter the number {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Displaying the elements in an array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The number at index {i} is {arr[i]}");
            }

            //Reading string array
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the string {i}: ");
                names[i] = Console.ReadLine();
            }

        }
    }
}
