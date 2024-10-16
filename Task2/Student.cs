using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
    class SchoolStudent : Student
    {
        public string SchoolName { get; set; }

        public override string ToString() => $"Name:{Name},Email:{Email},School:{SchoolName}";
    }
    class CollegeStudent : SchoolStudent
    {
        public string CollegeName { get; set; }
        public override string ToString() => $"Name:{Name},Email:{Email},College:{CollegeName}";
    }
}
