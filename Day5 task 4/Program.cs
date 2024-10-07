using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> data = new List<int[]>(); 

            Console.WriteLine("Enter the number of students:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter the number of subjects of Student {i + 1}:");
                int subject = int.Parse(Console.ReadLine()); 

                int[] marks = new int[subject]; 

               
                for (int j = 0; j < subject; j++)
                {
                    Console.Write($"Enter mark of Subject {j + 1}: ");
                    marks[j] = Convert.ToInt32(Console.ReadLine()); 
                }

                data.Add(marks); 
            }

            Console.WriteLine("\nMarks for each student:");
            for (int i = 0; i < data.Count; i++)
            {
                Console.Write($"Student {i + 1} marks: ");
                Console.WriteLine(string.Join(", ", data[i])); 
            }
        }
    }
}
