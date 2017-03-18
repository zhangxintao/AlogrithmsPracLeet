using System;
using AlgorithmsLeet.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.Arrays
{
    [TestClass]
    public class FirstPositiveNumberTest
    {
        [TestMethod]
        public void GetFirstMissingPositiveNumber_Given_Int_Array_Return_First_Missing_Positive_Number()
        {
            var firstPositive = new FirstPositiveNumber();
            var input = new int[] {5, 3, -1, 1};

            var result = firstPositive.GetFirstMissingPositiveNumber(input);

            Assert.AreEqual(2, result);
        }
    }
}
