using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2024
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 0)
            {
                return new List<IList<string>>();
            }

            Dictionary<string, List<string>> anagrams = new();

            foreach (string word in strs)
            {
                int[] count = new int[26];
                foreach (char c in word)
                {
                    count[c - 'a']++;
                }

                StringBuilder sb = new();
                for (int i = 0; i < 26; i++)
                {
                    sb.Append("#");
                    sb.Append(count[i]);
                }
                string key = sb.ToString();

                if (!anagrams.ContainsKey(key))
                {
                    anagrams[key] = new List<string>();
                }

                anagrams[key].Add(word);
            }
            return new List<IList<string>>(anagrams.Values);
        }
    }
}