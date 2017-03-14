using System;
using AlgorithmsLeet.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class LongestInsreasingSubsequenceTest
    {
        [TestMethod]
        public void MaxCount_Given_Integer_Sequence_Return_Longest_Increasing_Subsequence_Count()
        {
            var lis = new LongestIncreasingSubsequence();
            var input = new int[] {-3, 1, 7, 5, 6, 8};

            var count = lis.MaxCount(input);

            Assert.AreEqual(5, count);
        }
    }
}
