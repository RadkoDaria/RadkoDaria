using System;

namespace calculator.OneArgumentCalculators
{
    public class TwoPowerX : IOneArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}
