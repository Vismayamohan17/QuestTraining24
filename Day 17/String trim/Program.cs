using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_trim
{
    internal class Program
    {
        static bool TrimToFive(ref string text)
        {
            if(text.Length > 5)
            {
                text = text.Substring(0, 5);
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string data = "Old Data";
            if(TrimToFive(ref data))
            {
                Console.WriteLine(data + "...");
            }
            else
            {
                Console.WriteLine(data);
            }
        }
    }
}
