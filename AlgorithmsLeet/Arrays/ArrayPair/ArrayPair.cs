using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays.ArrayPair
{
    public class ArrayPair
    {
        public bool Pair(int[] input, int k)
        {
            var reminders = new int[k];

            for (var i = 0; i < input.Length; i++)
            {
                var reminder = input[i]%k;
                reminders[reminder]++;
            }

            for (var i = 0; i < k; i++)
            {
                if (i == 0)
                {
                    if (reminders[i]%2 != 0) return false;
                }
                else if (k%2 == 0 && i == k/2)
                {
                    if (reminders[i]%2 != 0) return false;
                }
                else
                {
                    if ((reminders[i] + reminders[k - i])%2 != 0)
                    {
                        return false;
                    }
                }

            }

            return true;
        }

    }
}
