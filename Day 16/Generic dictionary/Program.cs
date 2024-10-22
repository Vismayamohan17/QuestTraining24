using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_dictionary
{
    internal class Program
    {
        class Dict<TKey,Tvalue>
        {
            private Dictionary<TKey,Tvalue> _data = new Dictionary<TKey,Tvalue>();

            public void Add(TKey key,Tvalue value)
            {
                _data.Add(key, value);
            }
        }
        static void Main(string[] args)
        {
            var numberDict = new Dict<int,int>();
            numberDict.Add(1, 2);
            numberDict.Add(2, 3);
        }
    }
}
