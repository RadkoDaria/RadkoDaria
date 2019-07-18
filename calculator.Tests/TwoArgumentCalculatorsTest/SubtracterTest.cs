using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculatorsTest
{
    [TestFixture]
    public class SubtracterTest
    {
        [Test]
        public void Calculate()
        {
            Subtracter calculator = new Subtracter();
            double result = calculator.Calculate(10, 5);

            Assert.AreEqual(5, result);
        }
    }
}
