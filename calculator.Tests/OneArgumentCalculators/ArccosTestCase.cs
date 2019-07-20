using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class ArccosTestCase
    {
        [TestCase(0, 1.571)]
        [TestCase(1, 0)]
        [TestCase(-1, 3.142 )]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Arccos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
