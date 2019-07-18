using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Log2Test
    {
        [Test]
        public void Calculate()
        {
            Log2 calculator = new Log2();
            double result = calculator.Calculate(4);

            Assert.AreEqual(2, result, 0.001);
        }
    }
}
