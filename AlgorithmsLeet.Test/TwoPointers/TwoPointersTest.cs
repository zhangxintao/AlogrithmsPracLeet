using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.TwoPointers
{
    [TestClass]
    public class TwoPointersTest
    {
        [TestMethod]
        public void RemoveDuplicatesFromOrderedArray()
        {
            var a = new int[] {1, 1, 2, 3, 3};
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.RemoveDuplicatesFromOrderedArray(a);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ThreeSum_Given_Array_With_ThreeSum_Return_Any_Of_Them()
        {
            var a = new int[] {-2, 1, -1, 2, 1};
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.ThreeSum(a);

            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(-2, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(1, result[2]);
        }

        [TestMethod]
        public void MaxStockProfit_Given_StockPrices_Return_Max_Profit()
        {
            var a = new[] {7, 5, 1, 3, 6, 4};
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.MaxStockProfit(a);

            Assert.AreEqual(5, result);
        }
    }
}
