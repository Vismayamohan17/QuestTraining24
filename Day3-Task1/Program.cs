using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the string array: ");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            Console.WriteLine("Enter the strings (in lowercase):");

            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < size; i++)
            {
                arr[i] = arr[i].ToUpper(); 
            }

            Console.WriteLine("Array with uppercase strings:");
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Enter the strings (in uppercase):");

            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < size; i++)
            {
                arr[i] = arr[i].ToLower();
            }

            Console.WriteLine("Array with lowercase strings:");
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }



        }
    }
}
