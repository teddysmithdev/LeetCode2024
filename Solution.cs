using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode2024
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int a = 0;
            foreach (int i in nums)
            {
                a ^= i;
            }
            return a;
        }
    }
}