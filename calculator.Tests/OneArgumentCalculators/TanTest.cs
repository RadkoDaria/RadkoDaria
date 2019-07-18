using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TanTest
    {
        [Test]
        public void Calculate()
        {
            Tan calculator = new Tan();
            double result = calculator.Calculate(0);

            Assert.AreEqual(0, result, 0.001);
        }
    }
}
