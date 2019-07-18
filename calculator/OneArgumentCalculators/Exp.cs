using System;

namespace calculator.OneArgumentCalculators
{
   public class Exp:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
