using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class Degree2TestCase
    {
        [TestCase(1, 1)]
        [TestCase(3, 9)]
        [TestCase(2, 4)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Degree2();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
