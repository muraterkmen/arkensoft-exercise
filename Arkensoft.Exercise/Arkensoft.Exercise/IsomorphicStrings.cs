using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            var lists = new Dictionary<char, int>();
            var listt = new Dictionary<char, int>();

            foreach (var item in s)
            {
                if (lists.ContainsKey(item))
                {
                    lists[item]++;
                }
                else
                {
                    lists.Add(item, 1);
                }
            }

            foreach (var item in t)
            {
                if (listt.ContainsKey(item))
                {
                    listt[item]++;
                }
                else
                {
                    listt.Add(item, 1);
                }
            }

            var frequence1 = lists.Values.ToList();
            var frequence2 = listt.Values.ToList();

            foreach (var item in frequence1)
            {
                if (frequence2.Any(i => i == item))
                {
                    frequence2.Remove(item);
                }
                else
                {
                    return false;
                }
            }

            if (frequence2.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
