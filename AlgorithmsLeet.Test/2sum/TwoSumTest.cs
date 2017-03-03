using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.TwoSum;

namespace AlgorithmsLeet.Test._2sum
{
    [TestClass]
    public class TwoSumTest
    {
        #region TwoSum
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

        #endregion


        #region Two Sum to get index
        [TestMethod]
        public void GivenArrayWithTwoSum_Should_GetIndex()
        {
            var twoSumIndex = new TwoSum.TwoSumIndex();
            int[] input = new int[] { 1, 5, 7, 3 };
            var target = 10;
            var result = twoSumIndex.TwoSumFindIndex(input, target);
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
        }

        [TestMethod]
        public void GivenArrayWithoutTwoSum_Should_Get_Null()
        {
            var twoSumIndex = new TwoSum.TwoSumIndex();
            int[] input = new int[] { 1, 5, 7, 8 };
            var target = 10;
            var result = twoSumIndex.TwoSumFindIndex(input, target);
            Assert.IsNull(result);
        }
        #endregion 

    }
}
