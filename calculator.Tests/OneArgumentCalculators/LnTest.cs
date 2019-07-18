using calculator.OneArgumentCalculators;
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
    }
}
