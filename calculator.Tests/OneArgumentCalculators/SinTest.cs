using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class SinTest
    {
        [Test]
        public void Calculate()
        {
            Sin calculator = new Sin();
            double result = calculator.Calculate(0);

            Assert.AreEqual(0, result, 0.001);
        }
    }
}
