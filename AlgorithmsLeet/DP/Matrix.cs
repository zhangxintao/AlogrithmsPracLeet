using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class Matrix
    {
        public int MinimumSumOfPath(int[][] input)
        {
            var dp = new int[input.Length, input[0].Length];
            dp[0,0] = input[0][0];
            for (int i = 1; i < input.Length; i++)
            {
                dp[0,i] = input[0][i] + input[0][i - 1];
            }

            for (int j = 1; j < input.Length; j++)
            {
                dp[j,0] = input[j][0] + input[j - 1][0];
            }

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 1; j < input[0].Length; j++)
                {
                    var min = dp[i - 1, j] > dp[i, j - 1] ? dp[i, j - 1] : dp[i - 1, j];
                    dp[i, j] = input[i][j] + min;
                }
            }

            return dp[input.Length - 1, input[0].Length - 1];
        }
    }
}
