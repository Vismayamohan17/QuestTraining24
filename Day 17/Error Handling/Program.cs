using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two numbers: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int res = num1 / num2;
                Console.WriteLine(res);
            }
            //catch
            //{
            //    Console.WriteLine("Error occured.");      //here dont know the reason of error
            //}


            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);          //print just the error
            //    Console.WriteLine(e.StackTrace);      //print the detailed info about the error
            //}


            //for specifically written
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}


            //Overflow exception
            catch (OverflowException)
            {
                Console.WriteLine("Number too large.");
            }
        }
    }
}
