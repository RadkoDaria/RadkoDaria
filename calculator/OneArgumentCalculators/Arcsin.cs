using System;

namespace calculator.OneArgumentCalculators
{
    public class Arcsin:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Asin(firstValue);
        }
    }
}
