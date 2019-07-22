using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class SquareRootTestCase
    {
        [TestCase(1, 1)]
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new SquareRoot();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new SquareRoot();
            Assert.Throws<Exception>(() => calculator.Calculate(-2));
        }
    }
}
