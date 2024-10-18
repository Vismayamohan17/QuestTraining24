using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate void MathDelegate(int x, int y);
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Main(string[] args)
        {
            MathDelegate del = Add;
            del += Sub;
            del(1,2);

            //del -= Sub (To remove Sub)
        }




        //static int Add(int x , int y)
        //{
        //    return x + y;
        //}
        //static void Main(string[] args)
        //{
        //    MathDelegate del = Add;
        //    var res = del(1, 2);
         //   Console.WriteLine(res);
        //}


    }
}
