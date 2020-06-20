using MathsOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            int res = Calculator.Addition(20, 10);
            Assert.AreEqual(30, res);
        }
        
        [TestMethod]
        public void SubtractionTest()
        {
            int res = Calculator.Addition(20, 10);
            Assert.AreEqual(10, res);
        }

    }
}
