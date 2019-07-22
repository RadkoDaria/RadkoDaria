using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculators
{
    class MinTestCase
    {
        [TestCase(0, 1, 0)]
        [TestCase(3, 4, 3)]
        [TestCase(-7, -2, -7)]
        public void CalculateTest(
            double firstValue,
            double secondValue,
            double expected)
        {
            var calculator = new Min();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
