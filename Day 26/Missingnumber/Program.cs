using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missingnumber
{
    internal class Program
    {
        static int FindMissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }

            return expectedSum - actualSum;
        }

        static void Main()
        {
            int[] nums = { 3, 0, 1 };
            Console.WriteLine("Missing number: " + FindMissingNumber(nums));
        }
    }
}

