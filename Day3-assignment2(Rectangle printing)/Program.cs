using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_assignment2_Rectangle_printing_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*"); 
                    for (int j = 1; j < width - 1; j++)
                    {
                        Console.Write(" "); 
                    }
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
        }
    }
}
