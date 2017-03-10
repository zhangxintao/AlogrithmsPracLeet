using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Strs
{
    public class StrProblems
    {
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
    }
}
