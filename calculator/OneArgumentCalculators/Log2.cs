using System;

namespace calculator.OneArgumentCalculators
{
    public class Log2 : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(firstValue, 2); 
        }
    }
}
