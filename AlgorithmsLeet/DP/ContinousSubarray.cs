using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class ContinousSubarray
    {
        public int MaxSum(int[] input)
        {
            var dp = new int[input.Length];
            dp[0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (dp[i - 1] <= 0)
                {
                    dp[i] = input[i];
                }
                else
                {
                    dp[i] = dp[i - 1] + input[i];
                }
            }

            var max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                if (dp[i] > max)
                {
                    max = dp[i];
                }
            }

            return max;
        }
    }
}
