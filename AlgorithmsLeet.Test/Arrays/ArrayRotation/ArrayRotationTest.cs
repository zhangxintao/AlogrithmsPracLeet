using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.ArrayRotation;

namespace AlgorithmsLeet.Test.ArrayRotation
{
    [TestClass]
    public class ArrayRotationTest
    {
        [TestMethod]
        public void Array_Rotate_Right_Should_Get_Rotated_Result()
        {
            var input = new int[] {1, 2, 3, 4, 5};
            var rotation = new AlgorithmsLeet.ArrayRotation.ArrayRotation();
            
            var result = rotation.rotateRight(input, 2);

            CollectionAssert.AreEqual(new int[]{4, 5, 1, 2, 3}, result);
        }

        [TestMethod]
        public void Array_Rotate_0_Times_Should_Get_Original_Array()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var rotation = new AlgorithmsLeet.ArrayRotation.ArrayRotation();

            var result = rotation.rotateRight(input, 0);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, result);
        }

        #region Get minimum from rotated array

        #endregion
    }
}
