﻿using calculator.TwoArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentCalculatorsTest
{
    [TestFixture]
    public class MultiplyerTest
    {
        [Test]
        public void Calculate()
        {
            Multiplier calculator = new Multiplier();
            double result = calculator.Calculate(10, 5);

            Assert.AreEqual(50, result);
        }
    }
}
