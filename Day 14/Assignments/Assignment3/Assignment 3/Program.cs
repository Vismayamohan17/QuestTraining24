using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
        public interface IAnimal
        {
            void Speak();
        }
        public class Dog : IAnimal
        {
            public void Speak() => System.Console.WriteLine("BOW BOW");
        }
        public class Cat : IAnimal
        {
            public void Speak() => System.Console.WriteLine("MEOW MEOW");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var d = new Dog();
                d.Speak();
                var c = new Cat();
                c.Speak();
            }
        }
}
