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

        #region Three Sum

        public int[] ThreeSum(int[] a)
        {
            if (a.Length < 3) return a;

            Array.Sort(a);

            for (int i = 0; i < a.Length-2;i++)
            {
                int head = i + 1;
                int end = a.Length - 1;
                while (head < end)
                {
                    if (a[head] + a[end] + a[i] == 0)
                    {
                        return new int[] {a[i], a[head], a[end]};
                    }
                    else if (a[i] + a[head] + a[end] > 0)
                    {
                        end = end - 1;
                    }
                    else
                    {
                        head = head + 1;
                    }
                }
            }

            return null;
        }

        #endregion

        #region Stock Transaction

        public int MaxStockProfit(int[] a)
        {
            if (a == null || a.Length <= 1)
            {
                return 0;
            }

            int max = 0;
            int minI = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[minI])
                {
                    max = Math.Max(a[i] - a[minI], max);
                }
                else
                {
                    minI = i;
                }
            }

            return max;
        }

        #endregion

        #region Sort Colors

        public int[] SortColors(int[] a)
        {
            int head = 0;
            int tail = a.Length - 1;

            for (int i = 0; i < tail; i++)
            {
                if (a[i] == 0)
                {
                    var temp = a[i];
                    a[i] = a[head];
                    a[head] = temp;
                    head++;
                }

                if (a[i] == 2)
                {
                    var temp = a[i];
                    a[i] = a[tail];
                    a[tail] = temp;
                    tail--;
                    i--;
                }
            }

            return a;
        }

        #endregion

        #region can jump
        public bool CanJump(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                return false;
            }

            if (a[0] == 0)
            {
                return false;
            }

            int longest = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    if (longest <= i)
                    {
                        return false;
                    }
                }
                else
                {
                    longest = Math.Max(a[i] + i, longest);
                    if (longest >= a.Length - 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion
    }
}
