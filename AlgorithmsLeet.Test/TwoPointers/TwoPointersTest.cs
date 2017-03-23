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

        [TestMethod]
        public void SortColors_Given_Colors_Return_Sorted_Colors()
        {
            var a = new[] { 2, 1, 0, 2, 0 };
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.SortColors(a);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(1, result[2]);
            Assert.AreEqual(2, result[3]);
            Assert.AreEqual(2, result[4]);
        }

        [TestMethod]
        public void CanJump_Given_Jumpable_Array_Return_True()
        {
            var a = new[] { 2, 1, 3, 1, 1 };
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.CanJump(a);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanJump_Given_Not_Jumpable_Array_Return_False()
        {
            var a = new[] { 3, 2, 1, 0, 1 };
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.CanJump(a);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MaxArea_Given_Non_Negative_Array_Return_Max_Area()
        {
            var a = new[] { 0, 1, 3, 3, 2 };
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.MaxArea(a);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetMagnitudePoint_Given_Array_Return_MagnitudePoint()
        {
            var a = new[] { 1, 0, 1, 0, 1, 2, 3 };
            var instance = new AlgorithmsLeet.TwoPointers.TwoPointers();

            var result = instance.GetMagnitudePoint(a);

            Assert.AreEqual(5, result);
        }
    }
}
