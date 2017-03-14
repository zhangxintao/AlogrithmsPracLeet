using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.DP;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void MinimumSumOfPath_Given_Valid_Matrix_Return_Minimum_Sum_From_Top_To_Bottom()
        {
            var matrix = new Matrix();
            var input 
                = new int[][] { new[] { 2, 7, 3 },new[] { 1, 4, 5 },new[] { 10, 6, 9 } };

            var result = matrix.MinimumSumOfPath(input);

            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void TotalCountOfPath_Given_Valid_Matrix_Return_Total_Count_Of_Paths()
        {
            var matrix = new Matrix();
            var input
                = new int[][] { new[] { 1, 1, 1,1 }, new[] { 1, 4, 5, 2 }, new[] { 10, 6, 9, 8 } };

            var result = matrix.TotalCountOfPath(input);

            Assert.AreEqual(10, result);
        }
    }
}
