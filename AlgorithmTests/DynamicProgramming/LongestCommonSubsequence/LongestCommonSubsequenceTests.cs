using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.LongestCommonSubsequence
{
    [TestClass]
    public class LongestCommonSubsequenceTests
    {
        [TestMethod]
        public void LongestCommonSubsequenceTestOne()
        {
            int expected = Algorithm.DynamicProgramming.LongestCommonSubsequence.LongestCommonSubsequence.Main("AGGTAB", "GXTXAYB");
            int actual = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestCommonSubsequenceTestTwo()
        {
            int expected = Algorithm.DynamicProgramming.LongestCommonSubsequence.LongestCommonSubsequence.Main("ABCDEFG", "BCDGK");
            int actual = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestCommonSubsequenceTestThree()
        {
            int expected = Algorithm.DynamicProgramming.LongestCommonSubsequence.LongestCommonSubsequence.Main("ABCDGH", "AEDFHR");
            int actual = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}