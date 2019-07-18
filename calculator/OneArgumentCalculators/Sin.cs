using System;

namespace calculator.OneArgumentCalculators
{

    public class Sin :IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
    }
}
