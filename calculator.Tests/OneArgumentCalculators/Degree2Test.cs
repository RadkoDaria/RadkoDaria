using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Degree2Test
    {
        [Test]
        public void Calculate()
        {
            Degree2 calculator = new Degree2();
            double result = calculator.Calculate(2);

            Assert.AreEqual(4, result, 0.001);
        }
        [TestCase(1, 1)]
        [TestCase(3, 9)]
        [TestCase(2, 4)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Degree2();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
