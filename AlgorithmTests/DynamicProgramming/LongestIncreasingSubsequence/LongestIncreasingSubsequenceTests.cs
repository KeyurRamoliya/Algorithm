using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.LongestIncreasingSubsequence
{
    [TestClass]
    public class LongestIncreasingSubsequenceTests
    {
        [TestMethod]
        public void LongestIncreasingSubsequenceTestOne()
        {
            int expected = Algorithm.DynamicProgramming.LongestIncreasingSubsequence.LongestIncreasingSubsequence.Main(new[] { 1, 5, 2, 7, 8, 4 });
            int actual = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceTestTwo()
        {
            int expected = Algorithm.DynamicProgramming.LongestIncreasingSubsequence.LongestIncreasingSubsequence.Main(new[] { 10, 22, 9, 33, 21, 50, 41, 60 });
            int actual = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestIncreasingSubsequenceTestThree()
        {
            int expected = Algorithm.DynamicProgramming.LongestIncreasingSubsequence.LongestIncreasingSubsequence.Main(new[] { 5, 2, 7, 4, 3, 8 });
            int actual = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}