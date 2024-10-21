using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 6, 7, 9, 5, 4 };
            var result = data
                .Skip(3)
                .Take(5)
                .Where(i => i % 2 == 0)
                .Sum();
            Console.WriteLine(result);
            
        }
    }
}
