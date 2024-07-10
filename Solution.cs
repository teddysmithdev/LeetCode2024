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
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue;
            int left = 0;
            int currentSum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                currentSum += nums[right];

                while (currentSum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    currentSum -= nums[left];
                    left++;
                }
            }
            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}