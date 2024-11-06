using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumdata
{
    internal class Program
    {
        enum errortype
        {
            info,
            warning,
            type
        }
        static void Main(string[] args)
        {
            //var i = "info";
            //var t = Enum.Parse(typeof(errortype), i);
            //Console.WriteLine(t);

            int i = 0;
            errortype type = (errortype)i;
            Console.WriteLine(type);
        }
    }
}
