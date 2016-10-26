using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.MaximumSubarray
{
    [TestClass]
    public class MaximumSubarrayTests
    {
        [TestMethod]
        public void MaximumSubarrayTestOne()
        {
            int expected = Algorithm.DynamicProgramming.MaximumSubarray.MaximumSubarray.Main(new[] { -2, -3, 4, -1, -2, 1, 5, -3 });
            int actual = 7;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumSubarrayTestTwo()
        {
            int expected = Algorithm.DynamicProgramming.MaximumSubarray.MaximumSubarray.Main(new[] { 1, 2, -3, -4, 2, 7, -2, 3 });
            int actual = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MaximumSubarrayTestThree()
        {
            int expected = Algorithm.DynamicProgramming.MaximumSubarray.MaximumSubarray.Main(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            int actual = 6;
            Assert.AreEqual(expected, actual);
        }
    }
}