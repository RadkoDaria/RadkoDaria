using System;

namespace calculator.OneArgumentCalculators
{
    public class Arcsin:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue > 1 || firstValue<-1 )
            {
                throw new Exception("Ограничения arcsin");
            }

            return Math.Asin(firstValue);

        }
    }
}
