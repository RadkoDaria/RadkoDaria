using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculators
{
    class MaxTestCase
    {
        [TestCase(0, 1, 1)]
        [TestCase(3, 4, 4)]
        [TestCase(-7, -2, -2)]
        public void CalculateTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new Max();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
