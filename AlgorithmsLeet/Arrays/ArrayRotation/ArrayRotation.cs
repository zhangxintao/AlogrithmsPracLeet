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

            Reverse(input, 0, input.Length - 1);
            Reverse(input, 0, k - 1);
            Reverse(input, k, input.Length - 1);

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

        public int Min(int[] rotatedArray)
        {
            int low = 0;
            int high = rotatedArray.Length - 1;
            int min = rotatedArray[low];

            while (low < high - 1)
            {
                var mid = (low + high) / 2;
                if (rotatedArray[low] < rotatedArray[mid] && rotatedArray[mid] < rotatedArray[high])
                {
                    return rotatedArray[low];
                }

                if (rotatedArray[mid] < rotatedArray[low])
                {
                    high = mid;
                    min = Math.Min(min, rotatedArray[mid]);
                }
                else
                {
                    low = mid;
                    min = Math.Min(min, rotatedArray[mid]);
                }
            }

            return min;
        }

        public int Index(int[] rotatedArray, int target)
        {
            int low = 0;
            int high = rotatedArray.Length - 1;

            int mid = 0;
            while (low < high)
            {
                mid = (low + high) / 2;
                if (rotatedArray[mid] == target)
                {
                    return mid;
                }

                if (rotatedArray[mid] >= rotatedArray[low])
                {
                    if (target >= rotatedArray[low] && target <= rotatedArray[mid])
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
                else
                {
                    if (target >= rotatedArray[mid] && target <= rotatedArray[high])
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid;
                    }
                }
            }


            return -1;
        }
    }
}
