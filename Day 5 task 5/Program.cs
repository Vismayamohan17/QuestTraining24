using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> data = new Dictionary<int, List<int>>();

            Console.WriteLine("Enter the number of students:");
            int num = int.Parse(Console.ReadLine()); 

            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter Student ID for Student {i + 1}:");
                int studentId = int.Parse(Console.ReadLine()); 

                List<int> marks = new List<int>(); 

                Console.WriteLine("Enter number of subjects:");
                int subject = int.Parse(Console.ReadLine()); 

                for (int j = 0; j < subject; j++)
                {
                    Console.Write($"Enter mark for Subject {j + 1}: ");
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }

                data[studentId] = marks;
            }

            Console.WriteLine("\nMarks for each student:");
            foreach (var student in data)
            {
                Console.WriteLine($" Student ID:{student.Key}, Marks:{string.Join(", ", student.Value)}");
            }
        }
    }
}
