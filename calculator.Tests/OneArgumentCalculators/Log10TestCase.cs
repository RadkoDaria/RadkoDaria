using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class Log10TestCase
    {
        [TestCase(5, 0.699)]
        [TestCase(1, 0)]
        [TestCase(10, 1)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Log10();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
