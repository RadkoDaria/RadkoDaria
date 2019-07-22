using System;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Log10Test
    {
        [Test]
        public void Calculate()
        {
            Log10 calculator = new Log10();
            double result = calculator.Calculate(1);

            Assert.AreEqual(0, result, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new Log10();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
