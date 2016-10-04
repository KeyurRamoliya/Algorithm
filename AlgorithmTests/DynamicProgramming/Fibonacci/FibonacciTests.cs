using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.Fibonacci
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciTest()
        {
            int expected = Algorithm.DynamicProgramming.Fibonacci.Fibonacci.Main(10);
            int actual = 144;
            Assert.AreEqual(expected, actual);
        }
    }
}