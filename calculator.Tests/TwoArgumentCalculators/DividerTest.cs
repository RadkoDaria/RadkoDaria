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
    }
}
