using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class Anagram
    {
        /// <summary>
        /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once
        /// Example 1:
        ///Input: s = "anagram", t = "nagaram"
        ///Output: 
        ///
        ///Example 2:
        ///Input: s = "rat", t = "car"
        ///Output: false
        ///
        ///Constraints:
        //1 <= s.length, t.length <= 5 * 104
        //s and t consist of lowercase English letters.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }

            bool isAnagram = true;

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (var item in s)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency.Add(item, 1);
                }
            }

            foreach (var item in t)
            {
                if (frequency.Keys.Contains(item) && frequency[item] > 0)
                {
                    frequency[item]--;
                }
                else
                {
                    isAnagram = false;
                    break;
                }
            }

            var isAllMatced = !frequency.Values.Any(i => i > 0);

            return isAnagram && isAllMatced;
        }
    }
}
