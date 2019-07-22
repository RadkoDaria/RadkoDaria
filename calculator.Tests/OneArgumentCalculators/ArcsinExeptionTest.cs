using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{[TestFixture]
    public class ArcsinExeptionTest
    {
        [Test]
        public void CalculateTestExeptionTest()
        {
            IOneArgumentCalculator calculator=new Arcsin();
            Assert.Throws<Exception>(() => calculator.Calculate(3));
        }
    }
}
