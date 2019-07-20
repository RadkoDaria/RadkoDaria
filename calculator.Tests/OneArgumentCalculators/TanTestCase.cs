using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class TanTestCase
    {
        [TestCase(0, 0)]
        [TestCase(1, 1.557)]
        [TestCase(0.5, 0.546)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Tan();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
