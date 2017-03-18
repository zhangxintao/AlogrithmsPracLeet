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
        [TestMethod]
        public void Min_Given_Rotated_Array_Return_Min()
        {
            var input = new int[] { 5, 6, 1, 2, 3, 4};
            var rotation = new AlgorithmsLeet.ArrayRotation.ArrayRotation();

            var result = rotation.Min(input);

            Assert.AreEqual(1, result);
        }

        #endregion

        #region Search in rotated array
        [TestMethod]
        public void Index_Given_Rotated_Array_And_Target_Return_Index()
        {
            var input = new int[] {5, 6, 1, 2, 3, 4};
            var rotate = new AlgorithmsLeet.ArrayRotation.ArrayRotation();

            var index = rotate.Index(input, 1);

            Assert.AreEqual(2, index);
        }

        [TestMethod]
        public void Index_Given_Rotated_Array_And_Not_Exist_Target_Return_Minus_One()
        {
            var input = new int[] { 5, 6, 1, 2, 3, 4 };
            var rotate = new AlgorithmsLeet.ArrayRotation.ArrayRotation();

            var index = rotate.Index(input, 8);

            Assert.AreEqual(-1, index);
        }

        #endregion
    }
}
