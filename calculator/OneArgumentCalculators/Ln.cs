using System;

namespace calculator.OneArgumentCalculators
{
    public class Ln :IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(firstValue);
        }
    }
}
