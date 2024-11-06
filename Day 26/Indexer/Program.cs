using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
        class StringCollection
        {
            private string[] _strings;

           
            public StringCollection(int size)
            {
                _strings = new string[size];
            }

            public string this[int index]
            {
                get
                {
                    return _strings[index];
                }
                set
                {
                    _strings[index] = value;
                }
            }
        }

        class Program
        {
            static void Main()
            {
               
                StringCollection collection = new StringCollection(3);

                collection[0] = "Hello";
                collection[1] = "World";
                collection[2] = "Indexer";

                Console.WriteLine(collection[0]); 
                Console.WriteLine(collection[1]);
                Console.WriteLine(collection[2]);
            }
        }
}
