using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class LongestCommonSequence
    {
        public string GetLongestSubsequence(string s1, string s2)
        {
            var res = "";
            var m = s1.Length;
            var n = s2.Length;

            var dp = new int[m+1, n+1];
            int max = 0;
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else
                    {
                        if (s1[i-1] == s2[j-1])
                        {
                            dp[i, j] = dp[i - 1, j - 1] + 1;
                        }
                        else
                        {
                            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                        }   
                    }

                    if (dp[i, j] > max)
                    {
                        res += s2[j-1];
                        max = dp[i, j];
                    }

                }
            }
            return res;
        }
    }
}
