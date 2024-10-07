using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter numbers {i+1}: ");
                lst.Add(int.Parse(Console.ReadLine()));
            }

            for(int i = 0;i < lst.Count;i++)
            {
                if (lst[i] % 2 == 0)
                {
                    lst.Remove(i);
                }

            }
            Console.WriteLine(string.Join(",",lst));
           
        }
    }
}
