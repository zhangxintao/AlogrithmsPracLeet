using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class WordBreak
    {
        public List<string> GetSentenceRecur(string input, Dictionary<string, int> dict)
        {
            return GetSentenceRecur_Inner(input, dict, new Dictionary<string, List<string>>());
        }

        private List<string> GetSentenceRecur_Inner(string input, Dictionary<string, int> dict, Dictionary<string, List<string>> memoized )
        {
            var result = new List<string>();

            if (String.IsNullOrEmpty(input))
            {
                return result;
            }

            if (memoized.ContainsKey(input))
            {
                return result;
            }
            for (int i = 0; i < input.Length; i++)
            {
                var current = input.Substring(0, i + 1);
                if (dict.ContainsKey(current))
                {
                    foreach (var suffix in GetSentenceRecur_Inner(input.Substring(i), dict, memoized))
                    {
                        result.Add(current + " " + suffix);   
                    }
                }
                
            }
            memoized.Add(input, result);

            return result;
        }

    }
}
