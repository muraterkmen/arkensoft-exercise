using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class SubsequenceString
    {
        /*
         * leetcode 392
         * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
         * A subsequence of a string is a new string that is formed from the original string by deleting some (can be none)
         * of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
         * 
         * Input: s = "abc", t = "ahbgdc"
         * Output: true
         * 
         * Input: s = "axc", t = "ahbgdc"
         * Output: false
         * 
         */
        public bool IsSubsequence(string s, string t)
        {

            bool isSubsequence = true;

            if (string.IsNullOrEmpty(s))
            {
                return isSubsequence;
            }

            if (string.IsNullOrEmpty(t))
            {
                return false;
            }

            int lastFoundIndex = 0;
            bool foundChar = false;

            foreach (var chr in s)
            {
                foundChar = false;
                for (int i = lastFoundIndex; i < t.Length; i++)
                {
                    if (t[i] == chr)
                    {
                        foundChar = true;
                        lastFoundIndex = i + 1;
                        break;
                    }
                }

                if (!foundChar)
                {
                    isSubsequence = false;
                    break;
                }
            }

            return isSubsequence;
        }
    }
}
