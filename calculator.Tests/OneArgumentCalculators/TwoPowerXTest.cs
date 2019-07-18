using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TwoPowerXTest
    {
        [Test]
        public void Calculate()
        {
            TwoPowerX calculator = new TwoPowerX();
            double result = calculator.Calculate(2);

            Assert.AreEqual(4, result, 0.001);
        }
    }
}
