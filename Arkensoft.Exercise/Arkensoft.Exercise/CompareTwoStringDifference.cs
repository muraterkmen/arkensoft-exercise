using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class CompareTwoStringDifference
    {
        public char FindTheDifference(string s, string t)
        {
            char different = " "[0];

            var cdif = new Dictionary<char, int>();

            foreach (var chr in s)
            {
                if (cdif.Keys.Contains(chr))
                {
                    cdif[chr]++;
                }
                else
                {
                    cdif.Add(chr, 1);
                }
            }

            foreach (var item in t)
            {
                if (cdif.ContainsKey(item))
                {
                    if (cdif[item] > 0)
                    {
                        cdif[item]--;
                    }
                    else
                    {
                        different = item;
                        break;
                    }
                }
                else
                {
                    different = item;
                    break;
                }
            }

            return different;
        }
    }
}
