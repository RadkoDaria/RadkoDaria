using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TanTest
    {
        [Test]
        public void Calculate()
        {
            Tan calculator = new Tan();
            double result = calculator.Calculate(0);

            Assert.AreEqual(0, result, 0.001);
        }
        [TestCase(0, 0)]
        [TestCase(1, 1.557)]
        [TestCase(0.5, 0.546)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Tan();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
