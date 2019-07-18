using System;

namespace calculator.OneArgumentCalculators
{
    public class Arccos : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Acos(firstValue);
        }
    }
}
