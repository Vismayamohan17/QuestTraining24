using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13___ENUM
{
    internal class Program
    {
        public enum ConvertTo
        {
            Upper,
            Lower,
            Swapcase
        }

        public static void ConvertCasing(string input, ConvertTo targetType)
        {
            switch (targetType)
            {
                case ConvertTo.Upper:
                    System.Console.WriteLine(input.ToUpper());
                    break;
                case ConvertTo.Lower:
                    System.Console.WriteLine(input.ToLower());
                    break;

            }
        }
        static void Main()
        {
            ConvertCasing("Heloo", ConvertTo.Lower);
        }
    }
}

namespace ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\VISMAYA MOHAN\OneDrive\Desktop\Mishels notes";
            var fileName = "data.txt";
            var filePath = Path.Combine(path, fileName);
            Directory.CreateDirectory(path);
        }

    }
}
    
