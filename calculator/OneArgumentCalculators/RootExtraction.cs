using calculator.OneArgumentCalculators;
using System;

namespace calculator.OneArgumentCalculators
{
    /// <summary>
    /// Count RootExtraction
    /// </summary>
    public class RootExtraction : IOneArgumentCalculator
    {
        /// <summary>
        /// Finding RootExtraction
        /// </summary>
        /// <param name="firstValue">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// RootExtraction results
        /// </returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Отрицательно");
            }
            return Math.Sqrt(firstValue);
        }
    }
}