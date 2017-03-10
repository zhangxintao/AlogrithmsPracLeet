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
    }
}
