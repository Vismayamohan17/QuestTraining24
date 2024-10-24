using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_exceptions
{
    class MyCustomException : Exception
    {
        public string Message {  get; set; }

        public MyCustomException(string message)
        {
            Message = message;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two numbers: ");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                if (j == 0)
                {
                    throw new MyCustomException("Second number should not be zero.");

                }
                Console.WriteLine(i + j);
                Console.WriteLine(i - j);
                Console.WriteLine(i * j);
                Console.WriteLine(i / j);
            }
            catch (MyCustomException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
