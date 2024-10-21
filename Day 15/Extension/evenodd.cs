using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static  class evenodd
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }
}
