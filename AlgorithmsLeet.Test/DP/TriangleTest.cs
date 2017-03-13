using System;
using AlgorithmsLeet.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void MinimumSumOfPath_Given_A_Triangle_Return_Minimum_Sum_Of_Top_Down_Path()
        {
            var triangle = new Triangle();
            var input = new int[][] {new[] {2}, new[] {3, 4}, new[] {6, 5, 7}, new[] {8, 3, 9, 2}};

            var result = triangle.MinimumSumOfPath(input);

            Assert.AreEqual(13, result);
        }
    }
}
