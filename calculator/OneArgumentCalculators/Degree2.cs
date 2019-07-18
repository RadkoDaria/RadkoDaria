using System;

namespace calculator.OneArgumentCalculators
{
   public class Degree2 : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(firstValue, 2);
        }
    }
}
