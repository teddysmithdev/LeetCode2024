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
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder roman = new();
            for (int i = 0; i < values.Length && num > 0; i++)
            {
                while (values[i] <= num)
                {
                    num -= values[i];
                    roman.Append(symbols[i]);
                }
            }
            return roman.ToString();
        }
    }
}