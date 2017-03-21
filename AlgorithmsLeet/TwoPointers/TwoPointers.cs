using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.TwoPointers
{
    public class TwoPointers
    {
        #region remove duplicates from ordered array

        public int RemoveDuplicatesFromOrderedArray(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                return 0;
            }

            if (a.Length == 1)
            {
                return 1;
            }
            int j = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != a[j])
                {
                    j++;
                    a[j] = a[i];
                }
            }

            return j + 1;
        }

        #endregion
    }
}
