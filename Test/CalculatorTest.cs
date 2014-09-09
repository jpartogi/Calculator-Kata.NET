namespace Test
{
    using Calculator;
    using NUnit.Framework;

    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void EmptyStringReturns0()
        {
            Calculator calc = new Calculator();

            int result = calc.Add("");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void OneReturnsNumber()
        {
            Calculator calc = new Calculator();

            int result = calc.Add("1");

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
