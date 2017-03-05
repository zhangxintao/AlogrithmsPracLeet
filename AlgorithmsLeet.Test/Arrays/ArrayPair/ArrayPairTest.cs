using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.Arrays.ArrayPair
{
    [TestClass]
    public class ArrayPairTest
    {
        [TestMethod]
        public void GivenArrayWithValidPairs_Pair_Get_True()
        {
            var input = new int[] {2, 8, 4, 10, 1, 5};
            var k = 6;

            var result = new AlgorithmsLeet.Arrays.ArrayPair.ArrayPair().Pair(input, k);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenArrayWithoutValidPairs_Pair_Get_False()
        {
            var input = new int[] { 2, 8, 4, 7, 1, 5 };
            var k = 6;

            var result = new AlgorithmsLeet.Arrays.ArrayPair.ArrayPair().Pair(input, k);

            Assert.AreEqual(false, result);
        }
    }
}
