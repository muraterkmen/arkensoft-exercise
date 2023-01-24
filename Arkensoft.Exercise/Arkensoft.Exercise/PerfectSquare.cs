using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    internal class PerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num == 1)
            {
                return true;
            }

            int start = 1;
            int end = num;
            int mid = 0;

            while (start <= end)
            {
                mid = start + (end - start) / 2;
                if (mid * mid == num)
                {
                    return true;
                }
                else if ((decimal)mid * (decimal)mid > num)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return false;
        }
    }
}
