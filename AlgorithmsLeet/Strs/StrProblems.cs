using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Strs
{
    public class StrProblems
    {
        #region Checks whether a string contains dupliate chars
        public bool ContainsDuplication(string str)
        {
            Dictionary<char, int> strsDict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (strsDict.ContainsKey(str[i]))
                {
                    return true;
                }
                else
                {
                    strsDict.Add(str[i], 1);
                }
            }

            return false;
        }

        public bool ContainsDuplication_ASCII(string str)
        {
            bool[] mark = new bool[256];

            for (int i = 0; i < str.Length; i++)
            {
                if (mark[(int)str[i]])
                {
                    return true;
                }
                else
                {
                    mark[(int)str[i]] = true;
                }
            }

            return false;
        }
        #endregion

        #region Generate All possible combination for N pairs of Parenthesis

        public List<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            generateParenthesisInner(n, n, "", result);
            return result;
        }

        private void generateParenthesisInner(int left, int right, string currentStr, List<string> result)
        {
            if (left == 0 && right == 0)
            {
                result.Add(currentStr);
                return;
            }

            if (left > 0)
            {
                generateParenthesisInner(left - 1, right, currentStr + "(", result);
            }

            if (right > 0 && right > left)
            {
                generateParenthesisInner(left, right - 1, currentStr + ")", result);
            }
        }
        #endregion

        #region String exchange
        public List<string> Alternation(string str1, string str2)
        {
            var result = new List<string>();
            AlternationInner(str1, str2, "", result);
            return result;
        }

        private void AlternationInner(string str1, string str2, string current, List<string> result)
        {
            if (str1.Length == 0)
            {
                current += str2;
                result.Add(current);
                return;
            }

            if (str2.Length == 0)
            {
                current += str1;
                result.Add(current);
                return;
            }

            AlternationInner(str1.Substring(1), str2, current + str1.Substring(0, 1), result);
            AlternationInner(str1, str2.Substring(1), current + str2.Substring(0, 1), result);
        }
        #endregion

        #region integer string production
        public string Product(string str1, string str2)
        {
            var productLength = str1.Length + str2.Length;

            var result = new int[productLength];

            int currentResultIndex = productLength - 1;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                for (int j = str2.Length - 1; j >= 0; j--)
                {
                    var currentProduct = Convert.ToInt32(str1[i] - '0') * Convert.ToInt32(str2[j] - '0');
                    result[i + j + 1] += currentProduct;
                }
            }

            int carry = 0;
            for (int i = result.Length - 1; i >= 0; i--)
            { 
                result[i] += carry;
                carry = result[i] / 10;
                result[i] = result[i] % 10;
            }

            var resultStr = string.Empty;
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0 && result[i] == 0)
                {
                    continue;
                }

                resultStr += result[i].ToString();
            }

            return resultStr;

        }
        #endregion

        #region Check whether given string is a valid number
        public bool IsValidNumber(string str)
        {
            str = str.Trim();
            if (str.Length == 0)
            {
                return false;
            }

            for (var i = 0; i < str.Length; i++)
            {
                if ((i == 0 || i == str.Length - 1) && (str[i] == 'e' || str[i] == '.'))
                {
                    return false;
                }
                else if (str[i] != 'e' && str[i] != '.' && (str[i] - '0' > 9 || str[i] - '0' < 0))
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
