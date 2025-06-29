using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        [TestCase(2, 3, 5)]
        [TestCase(-4, 6, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(-2.5, -2.5, -5)]
        public void Addition_WhenCalled_ReturnsExpectedResult(double a, double b, double expected)
        {
            double actual = calculator.Addition(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
