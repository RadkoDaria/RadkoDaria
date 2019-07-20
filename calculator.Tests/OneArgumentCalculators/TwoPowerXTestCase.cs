using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class TwoPowerXTestCase
    {
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
