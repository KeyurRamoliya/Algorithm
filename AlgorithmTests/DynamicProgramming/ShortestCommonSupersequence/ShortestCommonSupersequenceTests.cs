using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.ShortestCommonSupersequence
{
    [TestClass]
    public class ShortestCommonSupersequenceTests
    {
        [TestMethod]
        public void ShortestCommonSupersequenceTestOne()
        {
            int expected = Algorithm.DynamicProgramming.ShortestCommonSupersequence.ShortestCommonSupersequence.Main("AGGTAB", "GXTXAYB");
            int actual = 9;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortestCommonSupersequenceTestTwo()
        {
            int expected = Algorithm.DynamicProgramming.ShortestCommonSupersequence.ShortestCommonSupersequence.Main("ABCDEFG", "BCDGK");
            int actual = 8;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShortestCommonSupersequenceTestThree()
        {
            int expected = Algorithm.DynamicProgramming.ShortestCommonSupersequence.ShortestCommonSupersequence.Main("ABCDGH", "AEDFHR");
            int actual = 9;
            Assert.AreEqual(expected, actual);
        }
    }
}