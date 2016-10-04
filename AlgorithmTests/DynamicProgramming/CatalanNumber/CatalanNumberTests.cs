using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests.DynamicProgramming.CatalanNumber
{
    [TestClass]
    public class CatalanNumberTests
    {
        [TestMethod]
        public void CatalanNumberTest()
        {
            int expected = Algorithm.DynamicProgramming.CatalanNumber.CatalanNumber.Main(10);
            int actual = 16796;
            Assert.AreEqual(expected, actual);
        }
    }
}