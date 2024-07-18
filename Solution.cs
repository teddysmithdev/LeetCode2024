using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2024
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int low = 0;
            int high = numbers.Length - 1;

            while (low < high)
            {
                int sum = numbers[low] + numbers[high];
                if (sum == target)
                {
                    return new int[] { low + 1, high + 1 };
                }
                else if (sum < target)
                {
                    low++;
                }
                else
                {
                    high--;
                }
            }
            return new int[] { -1, -1 };
        }
    }
}