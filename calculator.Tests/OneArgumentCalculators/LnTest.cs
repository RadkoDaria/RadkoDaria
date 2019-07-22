using System;
using calculator.OneArgumentCalculators;
using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class LnTest
    {
        [Test]
        public void Calculate()
        {
            Ln calculator = new Ln();
            double result = calculator.Calculate(1);

            Assert.AreEqual(0, result, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new Ln();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
