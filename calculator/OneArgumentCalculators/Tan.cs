using System;

namespace calculator.OneArgumentCalculators
{
    public class Tan: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}
