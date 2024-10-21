﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers
                .Skip(5)
                .Take(3);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
