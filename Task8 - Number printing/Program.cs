﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8___Number_printing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines: ");
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); 
                }
                Console.WriteLine(); 
            }
        }
    }
}