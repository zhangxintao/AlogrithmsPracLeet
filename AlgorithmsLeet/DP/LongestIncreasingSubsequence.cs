using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class LongestIncreasingSubsequence
    {
        public int MaxCount(int[] input)
        {
            var dp = new int[input.Length];
            dp[0] = 1;
            int max = 1;
            for (int i = 1; i < input.Length; i++)
            {
                var currentLongest = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (input[j] < input[i])
                    {
                        currentLongest = Math.Max(dp[j], currentLongest);
                    }
                }
                dp[i] = currentLongest + 1;
                max = Math.Max(dp[i], max);
            }

            return max;
        }
    }
}
