using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class CosTest
    {
        [Test]
        public void Calculate()
        {
            Cos calculator = new Cos();
            double result = calculator.Calculate(0);

            Assert.AreEqual(1, result, 0.001);
        }
        [TestCase(0, 1)]
        [TestCase(1, 0.540)]
        [TestCase(0, 1)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Cos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
