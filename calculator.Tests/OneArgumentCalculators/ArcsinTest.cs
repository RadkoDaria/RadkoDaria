using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators

    {
        [TestFixture]
        public class ArcsinTest
        {
            [Test]
            public void Calculate()
            {
                Arcsin calculator = new Arcsin();
                double result = calculator.Calculate(1);

                Assert.AreEqual(1.570, result, 0.001);
            }
        }
    }
