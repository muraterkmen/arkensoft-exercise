using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkensoft.Exercise
{
    public class FrequencyQueries
    {
        public List<int> freqQuery(List<List<int>> queries)
        {
            List<int> response = new List<int>();
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int key = 0;


            foreach (var query in queries)
            {
                key = query[1];

                if (query[0] == 1) //insert  means increase frequaence count
                {
                    if (frequency.Keys.Contains(key))
                    {
                        frequency[key] = frequency[key] + 1;
                    }
                    else
                    {
                        frequency.Add(key, 1);
                    }
                }
                else if (query[0] == 2) // delete value --> this means decrease frequency count
                {
                    if (frequency.Keys.Contains(key))
                    {
                        frequency[key]--;
                        if (frequency[key] <= 0)
                        {
                            frequency.Remove(key);
                        }
                    }
                }
                else if (query[0] == 3)// look for frequency number is equal or not
                {
                    if (frequency.Values.Contains(key))
                    {
                        response.Add(1);
                    }
                    else
                    {
                        response.Add(0);
                    }
                }
            }

            return response;
        }
    }
}
