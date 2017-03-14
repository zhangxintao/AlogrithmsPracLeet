using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.DP;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class PaintTest
    {
        [TestMethod]
        public void MinimumCost_Given_Cost_Return_Minimum_Cost()
        {
            var paint = new Paint();
            var cost = new int[][]
            {
                new int[] { 1, 2, 3},
                new int[] { 2, 2, 3},
                new int[] { 4, 2, 3},
                new int[] { 2, 1, 3}
            };

            var result = paint.MinimumCost(cost);

            Assert.AreEqual(7, result);
        }
    }
}
