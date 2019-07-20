using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class ArcsinTestCase
    {
        [TestCase(0, 0)]
        [TestCase(1,1.571 )]
        [TestCase(-1,-1.571)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Arcsin();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
