/*
 * Given an integer array A, find max value for i-j that satisfy A[i] < A[j] and i < j
 */
namespace AlgorithmsLeet.Arrays.MaxIndexDistance
{
    public class MaxIndexDistance
    {
        public int Get(int[] A)
        {
            var mark = new int[A.Length];

            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0 || A[i] < min)
                {
                    mark[i] = 1;
                    min = A[i];
                }
                else
                {
                    mark[i] = 0;
                }
            }

            int maxDistance = -1;
            for (int i = A.Length - 1, j = mark.Length - 1; i >= 0;)
            {
                while (mark[j] == 0 && j>0)
                {
                    j--;
                }

                if (A[i] > A[j] && (i - j) > maxDistance)
                {
                    maxDistance = i - j;
                    j--;
                }
                else
                {
                    i--;
                }

            }

            return maxDistance;
        }
    }
}
