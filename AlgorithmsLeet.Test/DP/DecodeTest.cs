using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.DP;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class DecodeTest
    {
        [TestMethod]
        public void Execute_Given_Encoded_Numbers_String_Return_Ways_of_Decoding()
        {
            var decode = new Decode();
            var input1 = "1";
            var input2 = "12";
            var input3 = "12926";
            var input4 = "10";

            var result1 = decode.Execute(input1);
            var result2 = decode.Execute(input2);
            var result3 = decode.Execute(input3);
            var result4 = decode.Execute(input4);

            Assert.AreEqual(1, result1);
            Assert.AreEqual(2, result2);
            Assert.AreEqual(4, result3);
            Assert.AreEqual(1, result4);
        }
    }
}
