using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15
{
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal Sound.");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark!");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Animal dog = new Dog();
                dog.MakeSound();  
            }
        }
}
