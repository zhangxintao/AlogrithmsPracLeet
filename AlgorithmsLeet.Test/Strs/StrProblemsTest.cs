using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsLeet.Strs;

namespace AlgorithmsLeet.Test.Strs
{
    [TestClass]
    public class StrProblemsTest
    {
        #region ContainsDuplication
        [TestMethod]
        public void GivenStringContainsDupliation_Return_True()
        {
            StrProblems strp = new StrProblems();
            string str = "AbcadA";

            var result = strp.ContainsDuplication(str);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GivenUniqueString_Return_False()
        {
            StrProblems strp = new StrProblems();
            string str = "AbcadB";

            var result = strp.ContainsDuplication(str);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ContainsDuplication_ASCII_GivenStringContainsDupliation_Return_True()
        {
            StrProblems strp = new StrProblems();
            string str = "AbcadA";

            var result = strp.ContainsDuplication_ASCII(str);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsDuplication_ASCII_GivenUniqueString_Return_False()
        {
            StrProblems strp = new StrProblems();
            string str = "AbcadB";

            var result = strp.ContainsDuplication_ASCII(str);

            Assert.IsFalse(result);
        }
        #endregion

        #region Generate All possible combination for N pairs of Parenthesis
        [TestMethod]
        public void GenerateParenthesis_Given_3_Pairs_Return_All_Combination()
        {
            var strProblem = new StrProblems();
            var n = 3;

            var result = strProblem.GenerateParenthesis(n);

            Assert.AreEqual(5, result.Count);
            Assert.IsTrue(result.Contains("((()))"));
            Assert.IsTrue(result.Contains("(())()"));
            Assert.IsTrue(result.Contains("(()())"));
            Assert.IsTrue(result.Contains("()(())"));
            Assert.IsTrue(result.Contains("()()()"));
        }
        #endregion
    }
}
