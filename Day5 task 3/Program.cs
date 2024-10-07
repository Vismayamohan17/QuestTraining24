using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<List<int>>();

            Console.WriteLine("Enter the number of students:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                List<int> marks = new List<int>();
                Console.WriteLine($"Enter marks of Student {i + 1} :");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Subject {j + 1}: ");
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }
                data.Add(marks);
            }

            Console.WriteLine("\nMarks of each student:");
            for (int i = 0; i < data.Count; i++)
            {
                Console.Write($"Student {i + 1} marks: ");
                Console.WriteLine(string.Join(", ", data[i]));
            }
        }
    }
}
