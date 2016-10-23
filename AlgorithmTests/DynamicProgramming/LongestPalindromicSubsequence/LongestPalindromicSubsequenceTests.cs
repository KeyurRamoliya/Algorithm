using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.LongestPalindromicSubsequence
{
    [TestClass]
    public class LongestPalindromicSubsequenceTests
    {
        [TestMethod]
        public void LongestPalindromicSubsequenceTestOne()
        {
            int expected = Algorithm.DynamicProgramming.LongestPalindromicSubsequence.LongestPalindromicSubsequence.Main("THISISAPALINDROMEEMORDNILAPASISIHT");
            int actual = 34;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubsequenceTestTwo()
        {
            int expected = Algorithm.DynamicProgramming.LongestPalindromicSubsequence.LongestPalindromicSubsequence.Main("AABCDEBAZ");
            int actual = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestPalindromicSubsequenceTestThree()
        {
            int expected = Algorithm.DynamicProgramming.LongestPalindromicSubsequence.LongestPalindromicSubsequence.Main("ACGTGTCAAAATCG");
            int actual = 8;
            Assert.AreEqual(expected, actual);
        }
    }
}