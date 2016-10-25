using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.MaximumPathSum
{
    [TestClass]
    public class MaximumPathSumTests
    {
        [TestMethod]
        public void MaximumPathSumTestOne()
        {
            int expected = Algorithm.DynamicProgramming.MaximumPathSum.MaximumPathSum.Main();
            int actual = 42;
            Assert.AreEqual(expected, actual);
        }
    }
}