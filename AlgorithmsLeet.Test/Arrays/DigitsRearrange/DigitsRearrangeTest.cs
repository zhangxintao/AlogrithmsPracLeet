using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.Arrays.DigitsRearrange
{
    [TestClass]
    public class DigitsRearrangeTest
    {
        [TestMethod]
        public void GivenXandY_Rearrange_Return_Closet_Array_To_Y()
        {
            var x = new int[] {1, 3, 2, 4};
            var y = new int[] {2, 4, 1, 0};
            var expected = new int[] {2, 4, 1, 3};

            var result = new AlgorithmsLeet.Arrays.DigitsRearrange.DigitsRearrange().Rearrange(x, y);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
