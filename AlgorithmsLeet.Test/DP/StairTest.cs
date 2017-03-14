using System;
using AlgorithmsLeet.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class StairTest
    {
        [TestMethod]
        public void GetWaysOfClimb_Given_Stairs_Return_Ways_of_Climbing()
        {
            var stair = new Stair();

            var result = stair.GetWaysOfClimb(4);

            Assert.AreEqual(5, result);
        }
    }
}
