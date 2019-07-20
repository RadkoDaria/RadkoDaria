using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class TenDegreeXTestCase
    {
        [TestCase(0, 1)]
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new TenDegreeX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
