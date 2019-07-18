using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class Degree2Test
    {
        [Test]
        public void Calculate()
        {
            Degree2 calculator = new Degree2();
            double result = calculator.Calculate(2);

            Assert.AreEqual(4, result, 0.001);
        }
    }
}
