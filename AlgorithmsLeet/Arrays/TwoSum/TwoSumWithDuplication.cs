using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.TwoSum
{
    public class TwoSumWithDuplication
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
 

        public void Save(int input)
        {
            if (dict.ContainsKey(input))
            {
                var item = dict[input];
                item++;
                dict[input] = item;
            }
            else
            {
                dict.Add(input, 1);
            }
        }

        public bool Test(int target)
        {
            foreach (var item in dict)
            {
                if (dict.ContainsKey(target - item.Key))
                {
                    var foundItem = dict[target - item.Key];
                    if (item.Key == (target -item.Key) && foundItem >= 2)
                    {
                        return true;
                    }
                    if (item.Key != (target-item.Key) && foundItem >= 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
