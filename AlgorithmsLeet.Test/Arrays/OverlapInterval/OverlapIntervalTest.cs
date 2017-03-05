using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using AlgorithmsLeet.Arrays.OverlapInterval;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.Arrays.OverlapInterval
{
    [TestClass]
    public class OverlapIntervalTest
    {
        #region Count Overlap Interval
        [TestMethod]
        public void GivenOverlapIntervals_CountOverlapIntervals_Should_Return_Count()
        {
            var intervals = new Interval[]
            {
                new Interval {Start = 1, End = 5}, new Interval {Start = 10, End = 15}, new Interval {Start = 5, End = 10},
                new Interval {Start = 20, End = 30}
            };
            var overlapInterval = new AlgorithmsLeet.Arrays.OverlapInterval.OverlapInterval();

            var result = overlapInterval.CountOverlapIntervals(intervals);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GivenSeparateIntervals_CountOverlapIntervals_Should_Return_Zero()
        {
            var intervals = new Interval[]
            {
                new Interval {Start = 1, End = 5}, new Interval {Start = 11, End = 15}, new Interval {Start = 6, End = 10},
                new Interval {Start = 20, End = 30}
            };
            var overlapInterval = new AlgorithmsLeet.Arrays.OverlapInterval.OverlapInterval();

            var result = overlapInterval.CountOverlapIntervals(intervals);

            Assert.AreEqual(0, result);
        }
        #endregion

        #region Insert Interval
        [TestMethod]
        public void GivenNonOverlapIntervals_InsertOverlapInterval_GetNonOverlapIntervals_Contains_the_New_Interval()
        {
            var intervals = new Interval[]
            {
                 new Interval {Start = 1, End = 5}, new Interval {Start = 6, End = 10}
            };

            var result = new IntervalInsert().Insert(intervals, new Interval() {Start = 4, End = 6});

            CollectionAssert.AreEqual(new List<Interval>(){new Interval(){Start = 1, End = 10}}, result);
        }


        [TestMethod]
        public void GivenNonOverlapIntevals_InsertNonOverlapInterval_GetNonOverlapIntervals_InOrder()
        {
            var intervals = new Interval[]
            {
                 new Interval {Start = 1, End = 3}, new Interval {Start = 6, End = 10}
            };
            var expected = new List<Interval>() {new Interval {Start = 1, End = 3}, new Interval { Start = 4, End = 5 }, new Interval {Start = 6, End = 10}};
            var result = new IntervalInsert().Insert(intervals, new Interval() { Start = 4, End = 5 });

            CollectionAssert.AreEqual(expected, result);
        }

        #endregion

        #region Merge Interval
        [TestMethod]
        public void GivenOverlapIntervals_Merge_GetMergedIntervals()
        {
            var intervals = new Interval[]
            {
                 new Interval {Start = 1, End = 5}, new Interval {Start = 6, End = 10}, new Interval {Start = 4, End = 6}, new Interval {Start = 15, End = 20}
            };
            var expected = new List<Interval>() { new Interval { Start = 1, End = 10 }, new Interval { Start = 15, End = 20 }};
            var result = new IntervalMerge().Merge(intervals);

            CollectionAssert.AreEqual(expected, result);
        }

        #endregion
    }
}
