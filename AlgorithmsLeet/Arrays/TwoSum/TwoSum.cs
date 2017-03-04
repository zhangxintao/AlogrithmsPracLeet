using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Given an integer array and a target, tell whether exist 2 integers that make sum of the 2 interger = target
 */
namespace AlgorithmsLeet.TwoSum
{
    public class TwoSum
    {
        public bool FindTwoSum_Solution1(int[] input, int target)
        {
            Array.Sort(input);
            
            for (int i = 0, j = input.Length - 1; i < j;)
            {
                if (input[i] + input[j] > target)
                {
                    j--;
                }
                else if (input[i] + input[j] < target)
                {
                    i++;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public bool FindTwoSum_Solution2(int[] input, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                dict.Add(input[i], i);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(target - input[i]) && input[i] != (target-input[i]))
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
