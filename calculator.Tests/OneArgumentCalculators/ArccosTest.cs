using System;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{

    [TestFixture]
    public class ArccosTest
    {
        [Test]
        public void Calculate()
        {
            Arccos calculator = new Arccos();
            double result = calculator.Calculate(0);

            Assert.AreEqual(1.571, result, 0.001);
        }

        [Test]
        public void CalculateTestExceptionTest()
        {
            IOneArgumentCalculator calculator = new Arccos();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
        [TestCase(0, 1.571)]
        [TestCase(1, 0)]
        [TestCase(-1, 3.142)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Arccos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
