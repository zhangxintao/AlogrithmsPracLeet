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
    }
}
