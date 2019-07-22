using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TwoPowerXTest
    {
        [Test]
        public void Calculate()
        {
            TwoPowerX calculator = new TwoPowerX();
            double result = calculator.Calculate(2);

            Assert.AreEqual(4, result, 0.001);
        }
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 4)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new TwoPowerX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
