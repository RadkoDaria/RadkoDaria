using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class RadiansTestCase
    {
        [TestCase(1, 0.017)]
        [TestCase(5, 0.087)]
        [TestCase(10, 0.175)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Radians();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
