using System;

namespace calculator.TwoArgumentCalculators
{
    public class RootExtraction : ITwoArgumentsCalculator
    {

        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, 1 / secondValue);
        }
    }
}


