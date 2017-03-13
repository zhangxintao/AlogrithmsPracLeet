using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.DP;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class ContinousSubarrayTest
    {
        [TestMethod]
        public void MaxSum_Given_Integer_Array_Return_Max_Sum_For_Continuous_Subarray()
        {
            var instance = new ContinousSubarray();
            var input = new[] { -3, 1, -3, 4, -1, 2, 1 };

            var maxSum = instance.MaxSum(input);

            Assert.AreEqual(6, maxSum);
        }
    }
}
