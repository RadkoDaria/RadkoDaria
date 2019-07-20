using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class CTanTestCase
    {
        [TestCase(-0.5,-1.830 )]
        [TestCase(1,0.642 )]
        [TestCase(0.5,1.830)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new CTan();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
