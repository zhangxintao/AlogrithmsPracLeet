using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays.DigitsRearrange
{
    public class DigitsRearrange
    {
        public int[] Rearrange(int[] x, int[] y)
        {
            Array.Sort(x);

            var used = new bool[x.Length];
            var result = new int[y.Length];

            for (int i = 0; i < y.Length; i++)
            {
                int j = 0;
                while (j < x.Length)
                {
                    if (x[j] >= y[i] && !used[j])
                    {
                        break;
                    }
                    j++;
                }
                result[i] = x[j];
                used[j] = true;
            }

            return result;
        }
    }
}
