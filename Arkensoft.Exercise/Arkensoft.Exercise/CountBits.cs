using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    internal class CountBits
    {
        public int[] GetCountBits(int n)
        {
            int[] result = new int[n+1];

            for (int i = 0; i <= n; i++)
            {
              result[i] = GetBits(i);
            }

            return result;
        }

        private int GetBits(int n)
        {
            int counter = 0;

            while (n > 0)
            {
                int mod = n % 2;
                if (mod == 1)
                {
                    counter++;
                }

                n = n - mod;
                n = n / 2;
            }

            return counter;
        }
    }
}
