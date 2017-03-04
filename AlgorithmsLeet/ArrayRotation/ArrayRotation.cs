using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.ArrayRotation
{
    public class ArrayRotation
    {
        public int[] rotateRight(int[] input, int k)
        {
            if (k <= 0)
            {
                return input;
            }

            Reverse(input, 0, input.Length -1);
            Reverse(input, 0, k-1);
            Reverse(input, k, input.Length -1);

            return input;
        }

        private void Reverse(int[] a, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                var temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
}
