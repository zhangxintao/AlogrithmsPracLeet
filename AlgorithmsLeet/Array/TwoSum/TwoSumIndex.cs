using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given an interger Array A, an integer target T, find the 2 integers from Array A that make sum of the 2 integers = T
 * Assume the integers are unique in Array A
 */
namespace AlgorithmsLeet.TwoSum
{
    public class TwoSumIndex
    {
        public int[] TwoSumFindIndex(int[] A, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++)
            {
                dict.Add(A[i], i);
            }

            int[] indexes = null;
            for (int i = 0; i < A.Length; i++)
            {
                if (dict.ContainsKey(target - A[i]) && A[i] != (target - A[i]))
                {
                    indexes = new int[2];
                    indexes[0] = i;
                    indexes[1] = dict[target - A[i]];
                    break;
                }
            }

            return indexes;
        }
    }
}
