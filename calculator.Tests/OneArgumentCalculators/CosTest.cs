using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class CosTest
    {
        [Test]
        public void Calculate()
        {
            Cos calculator = new Cos();
            double result = calculator.Calculate(0);

            Assert.AreEqual(1, result, 0.001);
        }
    }
}
