using System;

namespace calculator.OneArgumentCalculators
{
    public class SquareRoot : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sqrt(firstValue);
        }
    }
}