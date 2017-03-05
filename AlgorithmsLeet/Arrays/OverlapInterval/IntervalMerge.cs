using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays.OverlapInterval
{
    public class IntervalMerge
    {
        public List<Interval> Merge(Interval[] intervals)
        {
            var result = new List<Interval>();

            var i = 0;
            var n = intervals.Length;

            Array.Sort(intervals);
            while (i < n)
            {
                while (i < n - 1 && intervals[i].End < intervals[i+1].Start)
                {
                    result.Add(intervals[i]);
                    i++;
                }

                var item = intervals[i];
                while (i < n - 1 && intervals[i].End >= intervals[i + 1].Start)
                {
                    item.End = Math.Max(intervals[i].End, intervals[i + 1].End);
                    i++;
                }
                result.Add(item);
                i++;

                if (i == n - 1)
                {
                    result.Add(intervals[i]);
                    i++;
                }
            }

            return result;
        }
    }
}
