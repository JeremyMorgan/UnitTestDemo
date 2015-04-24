using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitTests;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        readonly Calculator _ourCalc = new Calculator();

        [TestMethod]
        public void CheckAddition()
        {
            double result = _ourCalc.Add(2, 4);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void CheckSubtraction()
        {
            double result = _ourCalc.Subtract(2, 4);
            Assert.AreEqual(result, -2);
        }

        [TestMethod]
        public void CheckMuliplication()
        {
            double result = _ourCalc.Multiply(2, 4);
            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void CheckDivision()
        {
            double result = _ourCalc.Divide(2, 4);
            Assert.AreEqual(result, .5);
        }
    }
}
