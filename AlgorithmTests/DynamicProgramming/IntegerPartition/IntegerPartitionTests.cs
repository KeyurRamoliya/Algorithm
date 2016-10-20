using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.IntegerPartition
{
    [TestClass]
    public class IntegerPartitionTests
    {
        [TestMethod]
        public void IntegerPartitionTestOne()
        {
            int expected = Algorithm.DynamicProgramming.IntegerPartition.IntegerPartition.Main(8, 8);
            int actual = 22;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntegerPartitionTestTwo()
        {
            int expected = Algorithm.DynamicProgramming.IntegerPartition.IntegerPartition.Main(4, 4);
            int actual = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}