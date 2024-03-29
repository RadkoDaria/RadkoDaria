﻿using System;
using calculator.OneArgumentCalculators;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentCalculators
{
    [TestFixture]
    public class LnTest
    {
        [Test]
        public void Calculate()
        {
            Ln calculator = new Ln();
            double result = calculator.Calculate(1);

            Assert.AreEqual(0, result, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new Ln();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
        [TestCase(3, 1.099)]
        [TestCase(1, 0)]
        [TestCase(2, 0.693)]
        public void CalculateTest(
            double firstValue,
            double expected)

        {
            var calculator = new Ln();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);

        }
    }
}
