using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signature
{
    internal class Program
    {
        //static int Calc(int a,int b,bool doAddition)
        //{
        //    return doAddition ? a + b : a - b;
        //}

        //static void Main(string[] args)
        //{
        //    var result = Calc( 2, 3,true);
        //    Console.WriteLine(result);
        //}

        static int Calc( bool doAddition,int a,int b)
        {
            return doAddition ? a + b : a - b;
        }

        static void Main(string[] args)
        {
            var result = Calc( true,2,3);
            Console.WriteLine(result);
        }
    }
}
