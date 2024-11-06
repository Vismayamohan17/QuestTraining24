using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Alice", 30);
            Console.WriteLine("Original Person:");
            person1.Display();

            Person person2 = new Person(person1);
            Console.WriteLine("Copied Person:");
            person2.Display();

            person2.Name = "Bob";
            person2.Age = 25;

            Console.WriteLine("After modifying the copied person:");
            Console.WriteLine("Original Person:");
            person1.Display();
            Console.WriteLine("Copied Person:");
            person2.Display();
        }
    }
}
