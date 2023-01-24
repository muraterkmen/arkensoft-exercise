using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class IntersectionofTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var set1 = new HashSet<int>(nums1);
            var set2 = new HashSet<int>(nums2);

            var list = new  HashSet<int>();

            if (set1.Count < set2.Count)
            {
                foreach (var item in set1)
                {
                    if (set2.Contains(item))
                    {
                        list.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in set2)
                {
                    if (set1.Contains(item))
                    {
                        list.Add(item);
                    }
                }
            }

            return list.ToArray();
        }
    }
}
