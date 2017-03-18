using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays
{
    public class MergeSortedArray
    {
        public void Merge(int[] a, int[] b)
        {
            int indexa = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    indexa = i - 1;
                    break;
                }
            }
            var indexb = b.Length - 1;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (indexa < 0)
                {
                    a[i] = b[indexb];
                    indexb--;
                }
                else if (indexb < 0)
                {
                    a[i] = a[indexa];
                    indexa--;
                }
                else
                {
                    if (a[indexa] >= b[indexb])
                    {
                        a[i] = a[indexa];
                        indexa--;
                    }
                    else
                    {
                        a[i] = b[indexb];
                        indexb--;
                    }   
                }
                
            }
        }
    }
}
