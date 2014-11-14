namespace Test
{
    using Calculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CalculatorTest
    {

        [TestMethod]
        public void EmptyStringReturns0()
        {
            Calculator calc = new Calculator();

            int result = calc.Add("");

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void OneReturnsNumber()
        {
            Calculator calc = new Calculator();

            int result = calc.Add("1");

            Assert.AreEqual(result, 1);
        }
    }
}
