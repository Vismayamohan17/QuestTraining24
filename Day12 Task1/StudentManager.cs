using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Task1
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void Add(Student stud)
        {
            // Check if the same student exists.
            if (GetStudentByRegNumber(stud.RegNumber) != null)
            {
                Console.WriteLine("Student already exists");
                return;
            }

            students.Add(stud);
            Console.WriteLine("Added successfully");
        }

        /// <summary>
        /// This method searches for a student based on the register number.
        /// </summary>
        /// <param name="RegNumber">The register number.</param>
        public void Search(string RegNumber)
        {
            var stud = GetStudentByRegNumber(RegNumber);
            Console.WriteLine(stud);
        }

        public void Update(string RegNumber, string Name, int Class)
        {
            var stud = GetStudentByRegNumber(RegNumber);
            if (stud == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            stud.Name = Name;
            stud.RegNumber = RegNumber;
            Console.WriteLine("Updated successfully");
        }

        public void Delete(string RegNumber)
        {
            var stud = GetStudentByRegNumber(RegNumber);
            if (stud == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            students.Remove(stud);
            Console.WriteLine("Deleted successfully");
        }

        private Student GetStudentByRegNumber(string RegNumber)
        {
            // Check if the same student exists.
            foreach (var stud in students)
            {
                if (stud.RegNumber == RegNumber)
                {
                    return stud;
                }
            }
            return null;
        }
    }
}

