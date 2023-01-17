using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    /// <summary>
    /// https://leetcode.com/problems/summary-ranges/
    /// Q.228
    /// You are given a sorted unique integer array nums.A range[a, b] is the set of all integers from a to b(inclusive).
    /// Return the smallest sorted list of ranges that cover all the numbers in the array exactly.That is, each element of nums is covered by exactly one of the ranges, 
    /// and there is no integer x such that x is in one of the ranges but not in nums.
    /// </summary>
    public class SummaryRanges
    {
        public List<string> GetSummaryRanges(int[] nums)
        {
            List<string> response = new List<string>();

            int a = 0;
            int b = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                a = nums[i];
                while (nums.Length - 1 > i && nums[i] + 1 == nums[i + 1])
                {
                    i++;
                }

                b = nums[i];

                if (a == b)
                {
                    response.Add(a.ToString());
                }
                else
                {
                    response.Add(a + "->" + b);
                }
            }

            return response;
        }
    }
}
