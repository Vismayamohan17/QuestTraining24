using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_and_Out
{
    internal class Program
    {
        //static void DoThis(ref int num)
        //{
        //    num = 0;
        //}
        //static void DoThis(out int num)
        //{
        //    num = 0;
        //}

        static void DoThis(ref string text)
        {
            text = "Hello";
        }
        static void Main(string[] args)
        {
            //int number = 1;
            //DoThis(ref number);
            //Console.WriteLine(number);

            //int number;
            //DoThis(out number);
            //Console.WriteLine(number);

            string texts = "Hi";
            DoThis(ref texts);
            Console.WriteLine(texts);
        }
    }
}
