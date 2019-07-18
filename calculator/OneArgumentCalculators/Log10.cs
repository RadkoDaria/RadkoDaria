using System;

namespace calculator.OneArgumentCalculators
{
    public class Log10 : IOneArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}
