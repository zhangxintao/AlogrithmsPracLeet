using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class Decode
    {
        public int Execute(string encoded)
        {
            if (String.IsNullOrEmpty(encoded))
            {
                return 0;
            }
            var dp = new int[encoded.Length];

            if (encoded[0] >= '1' && encoded[0] <= '9')
            {
                dp[0] = 1;
            }
            else
            {
                dp[0] = 0;
            }

            for (int i = 1; i < encoded.Length; i++)
            {
                if (encoded[i] == '0')
                {
                    dp[i] = dp[i - 1];
                }
                else
                {
                    if (encoded[i - 1] >= '2' || (encoded[i - 1] == '2' && encoded[i] > '6') || encoded[i] == '0')
                    {
                        dp[i] = dp[i - 1];
                    }

                    if ((encoded[i - 1] == '1' && encoded[i] != '0') || (encoded[i - 1] == '2' && encoded[i] <= '6'))
                    {
                        dp[i] = dp[i - 1] * 2;
                    }
                }
               
            }

            return dp[dp.Length - 1];
        }
    }
}
