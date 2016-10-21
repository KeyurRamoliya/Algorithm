using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.KnapsackProblem
{
    [TestClass]
    public class KnapsackProblemTests
    {
        [TestMethod]
        public void KnapsackProblemTestOne()
        {
            int expected = Algorithm.DynamicProgramming.KnapsackProblem.KnapsackProblem.Main(50, new[] {10, 20, 30},new[] {60, 100, 120});
            int actual = 220;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KnapsackProblemTestTwo()
        {
            int expected = Algorithm.DynamicProgramming.KnapsackProblem.KnapsackProblem.Main(10, new[] {5, 4, 6, 3},new[] {10, 40, 30, 50});
            int actual = 90;
            Assert.AreEqual(expected, actual);
        }
    }
}