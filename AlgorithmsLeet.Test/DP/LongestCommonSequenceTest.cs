using System;
using AlgorithmsLeet.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class LongestCommonSequenceTest
    {
        [TestMethod]
        public void GetLongestSubsequence_Given_Two_String_With_Common_Sequence_Return_The_Longest_Common_Sequence()
        {
            var lcs = new LongestCommonSequence();
            var s1 = "ABCD";
            var s2 = "EDCA";

            var result = lcs.GetLongestSubsequence(s1, s2);

            Assert.AreEqual("A", result);
        }
    }
}
