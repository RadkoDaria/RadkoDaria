using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class ExoTest
    {
        [Test]
        public void Calculate()
        {
            Exp calculator = new Exp();
            double result = calculator.Calculate(0);

            Assert.AreEqual(1, result, 0.001);
        }
        [TestCase(0, 1)]
        [TestCase(1, 2.718)]
        [TestCase(3, 20.085)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Exp();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
