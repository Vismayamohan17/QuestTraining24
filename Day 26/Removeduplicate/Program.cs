using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Removeduplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world This is a hello world program";
            var result = text.ToLower()
                .Split(' ')
                .Distinct();

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
