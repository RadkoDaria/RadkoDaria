using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class ExoTest
    {
        [Test]
        public void Calculate()
        {
            Exp calculator = new Exp();
            double result = calculator.Calculate(0);

            Assert.AreEqual(1, result, 0.001);
        }
    }
}
