using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTests
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Add_2Plus2_Returns4()
        {
            var result = Calc.Math.Add(2, 2);
            Assert.AreEqual(result, 4);
        }
        [TestMethod]
        public void Subtract_2Sub2_Returns0()
        {
            var result = Calc.Math.Subtract(2, 2);
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void Divide_2Div2_Returns1()
        {
            var result = Calc.Math.Divide(2, 2);
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void Multiple_2Mltp2_Returns4()
        {
            var result = Calc.Math.Multiply(2, 2);
            Assert.AreEqual(result, 4);
        }
    }
}
