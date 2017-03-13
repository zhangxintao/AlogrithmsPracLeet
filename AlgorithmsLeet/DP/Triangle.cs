using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class Triangle
    {
        public int MinimumSumOfPath(int[][] input)
        {
            var dp = new int[input.Length, input[input.Length-1].Length];

            for (int j = 0; j < input[input.Length - 1].Length; j++)
            {
                dp[input.Length - 1, j] = input[input.Length - 1][j];
            }

            for (int i = input.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    dp[i, j] = input[i][j] +
                               (dp[i + 1,j] > dp[i + 1,j + 1] ? dp[i + 1,j + 1] : dp[i + 1,j]);
                }
            }

            return dp[0, 0];
        }
    }
}
