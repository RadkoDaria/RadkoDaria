using System;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Log2Test
    {
        [Test]
        public void Calculate()
        {
            Log2 calculator = new Log2();
            double result = calculator.Calculate(4);

            Assert.AreEqual(2, result, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new Log2();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }

        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(8, 3)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Log2();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
