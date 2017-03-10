﻿using System;
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

        #region String exchange
        [TestMethod]
        public void Alternation_Given_Two_Strings_Return_All_Combinations_Keep_RelativeOrder()
        {
            var strProblem = new StrProblems();
            var str1 = "AB";
            var str2 = "CD";

            var result = strProblem.Alternation(str1, str2);

            Assert.AreEqual(6, result.Count);
            Assert.IsTrue(result.Contains("ABCD"));
            Assert.IsTrue(result.Contains("ACDB"));
            Assert.IsTrue(result.Contains("ACBD"));
            Assert.IsTrue(result.Contains("CDAB"));
            Assert.IsTrue(result.Contains("CABD"));
            Assert.IsTrue(result.Contains("CADB"));
        }
        #endregion

        #region string production
        [TestMethod]
        public void Production_Given_Two_String_Integers_Return_Production()
        {
            var strProblem = new StrProblems();
            var str1 = "123";
            var str2 = "456";

            var result = strProblem.Product(str1, str2);

            Assert.AreEqual("56088", result); 
        }
        #endregion

        #region check whether given string is a valid number
        [TestMethod]
        public void IsValidNumber_Given_Valid_String_Number_Return_True()
        {
            var strProblem = new StrProblems();
            var num1 = "123";
            var num2 = "2.1";
            var num3 = "2e1";

            var r1 = strProblem.IsValidNumber(num1);
            var r2 = strProblem.IsValidNumber(num2);
            var r3 = strProblem.IsValidNumber(num3);

            Assert.IsTrue(r1);
            Assert.IsTrue(r2);
            Assert.IsTrue(r3);
        }

        [TestMethod]
        public void IsValidNumber_Given_Invalid_String_Number_Return_False()
        {
            var strProblem = new StrProblems();
            var num1 = "1a";
            var num2 = ".1";
            var num3 = "e1";

            var r1 = strProblem.IsValidNumber(num1);
            var r2 = strProblem.IsValidNumber(num2);
            var r3 = strProblem.IsValidNumber(num3);

            Assert.IsFalse(r1);
            Assert.IsFalse(r2);
            Assert.IsFalse(r3);
        }

        #endregion
    }
}
