using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class LnTestCase
    {
        [TestCase(3, 1.099)]
        [TestCase(1, 0)]
        [TestCase(2, 0.693)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Ln();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
