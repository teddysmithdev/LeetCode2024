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
        private Dictionary<char, int> MakeCountMap(string s)
        {
            Dictionary<char, int> counts = new();
            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts[c] = 1;
                }
            }
            return counts;
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }

            Dictionary<char, int> magazineCounts = MakeCountMap(magazine);

            foreach (char c in ransomNote)
            {
                if (magazineCounts.TryGetValue(c, out int countInMagazine))
                {
                    if (countInMagazine == 0)
                    {
                        return false;
                    }

                    magazineCounts[c] = countInMagazine - 1;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}