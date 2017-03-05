using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays.GenerateRandomNumber
{
    public class GenerateRandomNumber
    {
        public int Generate(int[] a, int min, int max)
        {
            Array.Sort(a);
            Random r = new Random();
            while (true)
            {
                var number = r.Next(min, max);
                if (!BinarySearch(a, number, 0, a.Length - 1))
                {
                    return number;
                }
            }
        }

        private bool BinarySearch(int[] a, int target, int low, int high)
        {
            if (low > high) return false;
            
            var mid = (low + high)/2;
            if (a[mid] == target)
            {
                return true;
            }
            else if (target > a[mid])
            {
                return BinarySearch(a, target, mid + 1, high);
            }
            else
            {
                return BinarySearch(a, target, low, mid - 1);
            }
        }
    }
}
