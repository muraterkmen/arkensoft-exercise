using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class MissingNumber
    {
        public int FindMissingNumber(int[] nums)
        {
            int v = 0;
            int[] index = new int[nums.Length+1];

            foreach (var item in nums)
            {
                index[item]++;
            }

            for (int i = 0; i < index.Length;i++)
            {
                if (index[i] == 0)
                {
                    v = i;
                    break;
                }
            }

            return v;
        }
    }
}
