using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class ExpTestCase
    {
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
