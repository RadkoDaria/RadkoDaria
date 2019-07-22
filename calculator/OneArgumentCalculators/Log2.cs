using System;

namespace calculator.OneArgumentCalculators
{
    public class Log2 : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue <= 0)
            {
                throw new Exception("Аргумент должен быть > 0 ");
            }
            return Math.Log(firstValue, 2); 
        }
    }
}
