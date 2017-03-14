using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class Paint
    {
        public int MinimumCost(int[][] cost)
        {
            var dp = new int[cost.Length, cost[0].Length];

            dp[0, 0] = cost[0][0];
            dp[0, 1] = cost[0][1];
            dp[0, 2] = cost[0][2];

            for (int i = 1; i < cost.Length; i++)
            {
                dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + cost[i][0];
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + cost[i][1];
                dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i-1, 1]) + cost[i][2]; 
            }

            return Math.Min(dp[dp.GetLength(0) - 1, 0], Math.Min(dp[dp.GetLength(0) - 1, 1], dp[dp.GetLength(0) - 1, 2]));
        }
    }
}
