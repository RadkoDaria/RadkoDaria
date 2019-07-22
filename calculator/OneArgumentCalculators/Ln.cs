using System;

namespace calculator.OneArgumentCalculators
{
    public class Ln :IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if(firstValue<=0)
            {
                throw new Exception("Аргумент должен быть > 0 ");
            }

            return Math.Log(firstValue);
        }
    }
}
