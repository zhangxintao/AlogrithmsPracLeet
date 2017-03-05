using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.Array.MaxIndexDistance
{
    [TestClass]
    public class MaxIndexDistanceTest
    {
        [TestMethod]
        public void GivenArrayWithMaxDistance_Should_Get_Max_Distance()
        {
            var maxDis = new  AlgorithmsLeet.Arrays.MaxIndexDistance.MaxIndexDistance();

            var dis = maxDis.Get(new int[]{5, 3, 4, 0, 1, 4, 1});

            Assert.AreEqual(4, dis);
        }

        [TestMethod]
        public void GivenArrayWithoutMaxDistance_Should_Get_MinusOne()
        {
            var maxDis = new AlgorithmsLeet.Arrays.MaxIndexDistance.MaxIndexDistance();

            var dis = maxDis.Get(new int[] { 5, 4, 3, 2, 1 });

            Assert.AreEqual(-1, dis);
        }
    }
}
