using System;

namespace calculator.OneArgumentCalculators
{
    public class Cos :IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
