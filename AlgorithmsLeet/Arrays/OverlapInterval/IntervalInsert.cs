using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays.OverlapInterval
{
    public class IntervalInsert
    {
        public List<Interval> Insert(Interval[] intervals, Interval item)
        {
            var result = new List<Interval>();

            var i = 0;
            var length = intervals.Length;

            while (i < length && item.Start > intervals[i].End)
            {
                result.Add(intervals[i]);
                i ++;
            }

            while (i < length && item.End >= intervals[i].Start)
            {
                item.Start = intervals[i].Start < item.Start ? intervals[i].Start : item.Start;
                item.End = intervals[i].End > item.End ? intervals[i].End : item.End;
                i++;
            }
            result.Add(item);

            while (i < length)
            {
                result.Add(intervals[i]);
                i++;
            }

            return result;
        }
    }
}
