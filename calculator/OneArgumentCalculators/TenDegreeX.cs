using System;

namespace calculator.OneArgumentCalculators
{
    public class TenDegreeX : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(10, firstValue);
        }
    }
}
