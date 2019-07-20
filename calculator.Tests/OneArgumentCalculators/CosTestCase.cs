using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    
    class CosTestCase
    {
        [TestCase(0,  1)]
        [TestCase(1,  0.540)]
        [TestCase(0, 1)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Cos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult,0.001);

        }
    }
}
