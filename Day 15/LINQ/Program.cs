using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] data = { 1, 2, 3, 4, 5, 6, -1, 10 };
            var firstItem = data.First();
            Console.Write(firstItem);
            var firstOrDefault = data.FirstOrDefault();
            Console.Write(firstOrDefault);

            var last = data.Last();
            Console.Write(last);
            var lastOrDefault = data.LastOrDefault();
            Console.Write(lastOrDefault);

            var sortedAscending = data.OrderBy(x => x);
            Console.Write(sortedAscending);
            var sortedDescending = data.OrderByDescending(x => x);
            Console.Write(sortedDescending);

            var min = data.Min();
            Console.Write(min);
            var max = data.Max();
            Console.Write(max);

            var count = data.Count();
            Console.Write(count);
            var countOfNumbersLessThan5 = data.Count(x => x < 5);
            Console.Write(countOfNumbersLessThan5);

            var minGreaterThanFive = data.Min(x => x > 5);
            Console.Write(minGreaterThanFive);
            var maxGreaterThanFive = data.Max(x => x > 5);
            Console.Write(maxGreaterThanFive);

            var distinctElements = data.Distinct();
            Console.Write(distinctElements);

            var firstFive = data.Take(5);
            Console.Write(firstFive);
            var lastFive = data.Take(5);
            Console.Write(lastFive);

            var skipFirstFive = data.Skip(5);
            Console.Write(skipFirstFive);

            var skipFirstFiveAndTakeTheRemaining = data.Skip(5);
            Console.Write(skipFirstFiveAndTakeTheRemaining);

            var takeWhile = data.TakeWhile(i => i < 5);
            Console.Write(takeWhile);
            var skipWhile = data.SkipWhile(i => i < 5);
            Console.Write(skipWhile);

            var where = data.Where(i => i < 5);
            Console.Write(where);


        }
    }
}
