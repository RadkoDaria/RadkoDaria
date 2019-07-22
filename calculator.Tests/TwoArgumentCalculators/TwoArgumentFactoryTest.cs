using System;
using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculators
{
    class TwoArgumentFactoryTest
    {

        [TestCase("add", typeof(Adder))]
        [TestCase("Average", typeof(Average))]
        [TestCase("Min", typeof(Min))]
        [TestCase("Max", typeof(Max))]
        [TestCase("div", typeof(Divider))]
        [TestCase("XExpY", typeof(Exponentiation))]
        [TestCase("GeoMean", typeof(GeometricMean))]
        [TestCase("Max", typeof(Max))]
        [TestCase("Min", typeof(Min))]
        [TestCase("mult", typeof(Multiplier))]
        [TestCase("Root", typeof(RootExtraction))]
        [TestCase("sub", typeof(Subtracter))]
    
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
