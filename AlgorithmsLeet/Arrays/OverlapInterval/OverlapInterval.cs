using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLeet.Arrays.OverlapInterval
{

    public class Interval : IComparable<Interval>
    {
        public int Start { get; set; }

        public int End { get; set; }


        public int CompareTo(Interval other)
        {
            return this.Start.CompareTo(other.Start);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Interval;
            if (item == null)
            {
                return false;
            }

            return this.Start == item.Start && this.End == item.End;
        }


        public override int GetHashCode()
        {
            return this.Start.GetHashCode() + this.End.GetHashCode();
        }
    }

    public class OverlapInterval
    {
        public int CountOverlapIntervals(Interval[] intervals)
        {
            Array.Sort(intervals);

            int count = 0;
            Interval combinedInterval = null;
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i + 1].Start <= intervals[i].End)
                {
                    if (combinedInterval == null)
                    {
                        count += 2;
                        combinedInterval = new Interval()
                        {
                            Start = intervals[i].Start,
                            End = intervals[i].End > intervals[i + 1].End ? intervals[i].End : intervals[i + 1].End
                        };
                    }
                    else
                    {
                        combinedInterval.End = combinedInterval.End > intervals[i + 1].End
                            ? combinedInterval.End
                            : intervals[i + 1].End;
                        count++;
                    }
                }
                else
                {
                    combinedInterval = null;
                }
            }

            return count;
        }
    }
}
