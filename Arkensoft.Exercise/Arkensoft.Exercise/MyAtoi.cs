
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class MyAtoi
    {
        public int GetMyAtoi(string s)
        {
            string respones = "";
            bool includeDot = false;

            s = s.Trim();
            string[] values = s.Split(' ');

            foreach (var item in values[0])
            {
                if (respones.Length > 0 && item == '.')
                {
                    includeDot = true;
                    break;
                }

                if (!char.IsDigit(item) && item != '-')
                {
                    break;
                }

                respones = respones + item.ToString();
            }

            if (!includeDot && values[0].Length != respones.Length)
            {
                return 0;
            }

            try
            {
                return int.Parse(respones);
            }
            catch (Exception e)
            {
                if (respones.StartsWith('-'))
                {
                    return int.MinValue;
                }
                else
                {
                    return int.MaxValue;
                }
            }
        }
    }
}
