using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculators
{
    class ExponentiationTestCase
    {
        [TestCase(5, 2, 25)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 2, 9)]
        public void CalculateTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new Exponentiation();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}
