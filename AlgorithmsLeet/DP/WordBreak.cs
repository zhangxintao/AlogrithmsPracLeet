using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.DP
{
    public class WordBreak
    {
        public string GetSentenceRecur(string input, Dictionary<string, int> dict)
        {
            return GetSentenceRecur_Inner(input, dict);
        }

        private string GetSentenceRecur_Inner(string input, Dictionary<string, int> dict)
        {
            var result = string.Empty;
            if (String.IsNullOrEmpty(input))
            {
                return result;
            }

            
            for (int i = 0; i < input.Length; i++)
            {
                var current = input.Substring(0, i + 1);
                if (dict.ContainsKey(current))
                {
                    if (i + 1 == input.Length)
                    {
                        result += current;
                    }
                    else
                    { 
                        var suffix = GetSentenceRecur_Inner(input.Substring(i+1), dict);
                        if (!string.IsNullOrEmpty(suffix))
                        {
                            result += current + " " + suffix;
                        }
                    }
                }
                
            }

            return result;
        }


        public string GetSentenceMemoi(string input, Dictionary<string, int> dict)
        {
            return GetSentenceMemoi_Inner(input, dict, new Dictionary<string, string>());
        }

        private string GetSentenceMemoi_Inner(string input, Dictionary<string, int> dict, Dictionary<string, string> memoi)
        {
            var result = string.Empty;

            if (string.IsNullOrEmpty(input))
            {
                return result;
            }

            if(memoi.ContainsKey(input))
            {
                return memoi[input];
            }

            for (int i = 0; i < input.Length; i++)
            {
                var current = input.Substring(0, i + 1);

                if (dict.ContainsKey(current))
                {
                    if (i + 1 == input.Length)
                    {
                        result += current;
                    }
                    else
                    {
                        var suffix = GetSentenceMemoi_Inner(input.Substring(i + 1), dict, memoi);
                        if (!string.IsNullOrEmpty(suffix))
                        {
                            result += current + " " + suffix;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(result))
            {
                memoi.Add(input, result);
            }
            return result;
        }

    }
}
