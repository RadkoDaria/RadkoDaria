using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;
using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    class OneArgumentFactoryTest
    {

        [TestCase("Arccos(x)", typeof(Arccos))]
        [TestCase("Arcsin(x)", typeof(Arcsin))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
