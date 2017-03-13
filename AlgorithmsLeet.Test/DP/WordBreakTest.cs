using System;
using System.Collections.Generic;
using AlgorithmsLeet.DP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsLeet.Test.DP
{
    [TestClass]
    public class WordBreakTest
    {
        [TestMethod]
        public void GetSentenceRecur_Given_Not_Break_Sentence_And_Dict_Return_Valid_Sentence_Based_On_Dict()
        {
            WordBreak wb = new WordBreak();
            var input = "thisisanexample";
            var dict = new Dictionary<string, int>();
            dict.Add("this", 1);
            dict.Add("an", 1);
            dict.Add("example", 1);
            dict.Add("is", 1);

            var result = wb.GetSentenceRecur(input, dict);

            Assert.AreEqual(4, result.Split(' ').Length);
            Assert.AreEqual("this", result.Split(' ')[0]);
            Assert.AreEqual("is", result.Split(' ')[1]);
            Assert.AreEqual("an", result.Split(' ')[2]);
            Assert.AreEqual("example", result.Split(' ')[3]);
        }

        [TestMethod]
        public void GetSentenceRecur_Given_Not_Break_Sentence_And_Overlap_Dict_Return_Valid_Sentence_Based_On_Dict()
        {
            WordBreak wb = new WordBreak();
            var input = "thisisanexample";
            var dict = new Dictionary<string, int>();
            dict.Add("this", 1);
            dict.Add("thi", 1);
            dict.Add("an", 1);
            dict.Add("example", 1);
            dict.Add("exam", 1);
            dict.Add("is", 1);

            var result = wb.GetSentenceRecur(input, dict);

            Assert.AreEqual(4, result.Split(' ').Length);
            Assert.AreEqual("this", result.Split(' ')[0]);
            Assert.AreEqual("is", result.Split(' ')[1]);
            Assert.AreEqual("an", result.Split(' ')[2]);
            Assert.AreEqual("example", result.Split(' ')[3]);
        }

        [TestMethod]
        public void GetSentenceMemoi_Given_Not_Break_Sentence_And_Dict_Return_Valid_Sentence_Based_On_Dict()
        {
            WordBreak wb = new WordBreak();
            var input = "thisisanexample";
            var dict = new Dictionary<string, int>();
            dict.Add("this", 1);
            dict.Add("an", 1);
            dict.Add("example", 1);
            dict.Add("is", 1);

            var result = wb.GetSentenceMemoi(input, dict);

            Assert.AreEqual(4, result.Split(' ').Length);
            Assert.AreEqual("this", result.Split(' ')[0]);
            Assert.AreEqual("is", result.Split(' ')[1]);
            Assert.AreEqual("an", result.Split(' ')[2]);
            Assert.AreEqual("example", result.Split(' ')[3]);
        }

        [TestMethod]
        public void GetSentenceMemoi_Given_Not_Break_Sentence_And_Overlap_Dict_Return_Valid_Sentence_Based_On_Dict()
        {
            WordBreak wb = new WordBreak();
            var input = "thisisanexample";
            var dict = new Dictionary<string, int>();
            dict.Add("this", 1);
            dict.Add("thi", 1);
            dict.Add("an", 1);
            dict.Add("example", 1);
            dict.Add("exam", 1);
            dict.Add("is", 1);

            var result = wb.GetSentenceMemoi(input, dict);

            Assert.AreEqual(4, result.Split(' ').Length);
            Assert.AreEqual("this", result.Split(' ')[0]);
            Assert.AreEqual("is", result.Split(' ')[1]);
            Assert.AreEqual("an", result.Split(' ')[2]);
            Assert.AreEqual("example", result.Split(' ')[3]);
        }
    }
}
