using System;

namespace calculator.OneArgumentCalculators
{
    /// <summary>
    /// Count Arcsin
    /// </summary>
    
    public class Arcsin:IOneArgumentCalculator
    {
        /// <summary>
        /// Count Arcsin
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <returns>
        /// Arcsin results in radians
        /// </returns>
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
