using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.Arrays.GenerateRandomNumber
{
    [TestClass]
    public class GenerateRandomNumberTest
    {
        [TestMethod]
        public void GivenArrayWithMaxAndMin_Generate_Should_ReturnUniqueRandomNumber()
        {
            var input = new int[] {2, 7, 10, 3, 20, 15};
            var max = 20;
            var min = 2;

            var result = new AlgorithmsLeet.Arrays.GenerateRandomNumber.GenerateRandomNumber().Generate(input, min, max);

            Assert.IsTrue(!input.Contains(result));
        }
    }
}
