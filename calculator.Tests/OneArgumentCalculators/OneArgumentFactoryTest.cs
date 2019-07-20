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

        [TestCase("Arccos", typeof(Arccos))]
        [TestCase("Arcsin", typeof(Arcsin))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("CTan", typeof(CTan))]
        [TestCase("Degree2", typeof(Degree2))]
        [TestCase("Exp", typeof(Exp))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Log10", typeof(Log10))]
        [TestCase("Log2", typeof(Log2))]
        [TestCase("Radians", typeof(Radians))]
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Tan", typeof(Tan))]
        [TestCase("TenDegreeX", typeof(TenDegreeX))]
        [TestCase("TwoPowerX", typeof(TwoPowerX))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
