using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class TenDegreeXTest
    {
        [Test]
        public void Calculate()
        {
            TenDegreeX calculator = new TenDegreeX();
            double result = calculator.Calculate(2);

            Assert.AreEqual(100, result, 0.001);
        }
    }
}
