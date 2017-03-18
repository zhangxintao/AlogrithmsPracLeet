using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using AlgorithmsLeet.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.Arrays
{
    [TestClass]
    public class MergeSortedArrayTest
    {
        [TestMethod]
        public void Merge_Given_Array_A_B_Return_Merge_B_Into_A()
        {
            var a = new int[10] {2, 4, 6, 8, 10, 12, 0, 0, 0, 0};
            var b = new int[] {1, 3, 5, 7};
            var merge = new MergeSortedArray();

            merge.Merge(a, b);

            CollectionAssert.AreEqual(new int[]{1, 2, 3, 4,5, 6, 7, 8, 10, 12}, a);
        }
    }
}
