using System;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators

{
    [TestFixture]
    public class ArcsinTests
    {
        [Test]
        public void Calculate()
        {
            Arcsin calculator = new Arcsin();
            double result = calculator.Calculate(1);

            Assert.AreEqual(1.570, result, 0.001);
        }
        [TestCase(0, 0)]
        [TestCase(1, 1.571)]
        [TestCase(-1, -1.571)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Arcsin();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
        [Test]
        public void CalculateTestExeptionTest()
        {
            IOneArgumentCalculator calculator = new Arcsin();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }



}
