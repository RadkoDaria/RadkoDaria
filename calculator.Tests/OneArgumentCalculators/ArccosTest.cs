using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{

    [TestFixture]
    public class ArccosTest
    {
        [Test]
        public void Calculate()
        {
            Arccos calculator = new Arccos();
            double result = calculator.Calculate(0);

            Assert.AreEqual(1.571, result, 0.001);
        }
    }
}
