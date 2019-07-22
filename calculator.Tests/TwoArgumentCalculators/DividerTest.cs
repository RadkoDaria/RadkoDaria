using System;
using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculatorsTest
{
    [TestFixture]
    public class DividerTest
    {
        [Test]
        public void Calculate()
        {
            Divider calculator = new Divider();
            double result = calculator.Calculate(10, 5);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new Divider();
            Assert.Throws<Exception>(() => calculator.Calculate(3,0));
        }
    }
    
}
