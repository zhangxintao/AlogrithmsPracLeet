using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays
{
    public class FirstPositiveNumber
    {
        public int GetFirstMissingPositiveNumber(int[] array)
        {
            var length = array.Length;

            var mappedArray = new bool[length];

            for (var i = 0; i < length; i++)
            {
                if (array[i] <= length && array[i] >= 1)
                {
                    mappedArray[i - 1] = true;
                }
            }

            for (var i = 0; i < length; i++)
            {
                if (!mappedArray[i])
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
