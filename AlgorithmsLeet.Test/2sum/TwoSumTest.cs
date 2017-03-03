using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.TwoSum;

namespace AlgorithmsLeet.Test._2sum
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void GivenArrayWithTwoSum_Should_GetTrue_Solution1()
        {
            var twoSum = new TwoSum.TwoSum();
            int[] input = new int[] { 1, 5, 7, 3 };
            var target = 10;
            var result = twoSum.FindTwoSum_Solution1(input, target);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenArrayWithTwoSum_Should_GetTrue_Solution2()
        {
            var twoSum = new TwoSum.TwoSum();
            int[] input = new int[] { 1, 5, 7, 3 };
            var target = 10;
            var result = twoSum.FindTwoSum_Solution2(input, target);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenArrayWithoutTwoSum_Should_GetFalse_Solution1()
        {
            var twoSum = new TwoSum.TwoSum();
            int[] input = new int[] { 1, 5, 7, 8};
            var target = 10;
            var result = twoSum.FindTwoSum_Solution1(input, target);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenArrayWithoutTwoSum_Should_GetFalse_Solution2()
        {
            var twoSum = new TwoSum.TwoSum();
            int[] input = new int[] { 1, 5, 7, 8 };
            var target = 10;
            var result = twoSum.FindTwoSum_Solution2(input, target);
            Assert.AreEqual(false, result);
        }

    }
}
