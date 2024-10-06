using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_Number_printing_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines: ");
            int lines = int.Parse(Console.ReadLine());

            int currentNumber = 1; 

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " "); 
                    currentNumber++; 
                }
                Console.WriteLine(); 
            }
        }
    }
}
