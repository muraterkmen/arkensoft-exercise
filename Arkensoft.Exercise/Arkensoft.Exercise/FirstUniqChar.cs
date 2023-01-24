using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class FirstUniqChar
    {
        public int FindFirstUniqChar(string s)
        {
            int index = -1;

            if (string.IsNullOrEmpty(s))
            {
                return index;
            }

            var frequences = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (frequences.Keys.Contains(s[i]))
                {
                    frequences[s[i]] = -1;
                }
                else
                {
                    frequences.Add(s[i], i);
                }
            }

            foreach (var item in frequences)
            {
                if (item.Value > -1)
                {
                    index = item.Value;
                    break;
                }
            }

            return index;
        }
    }
}
