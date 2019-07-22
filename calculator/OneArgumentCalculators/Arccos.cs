using System;

namespace calculator.OneArgumentCalculators
{
    public class Arccos : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue > 1 || firstValue < -1)
            {
                throw new Exception("Ограничения arccos");
            }
            return Math.Acos(firstValue);
        }
    }
}
