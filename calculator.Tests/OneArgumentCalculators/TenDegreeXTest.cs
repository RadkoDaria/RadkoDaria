using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TenDegreeXTest
    {
        [Test]
        public void Calculate()
        {
            TenDegreeX calculator = new TenDegreeX();
            double result = calculator.Calculate(2);

            Assert.AreEqual(100, result, 0.001);
        }
        [TestCase(0, 1)]
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new TenDegreeX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
