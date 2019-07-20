using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class Log2TestCase
    {
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
