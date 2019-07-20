using System;

namespace calculator.TwoArgumentCalculators
{
    /// <summary>
    /// Count Geometric Mean
    /// </summary>
    public class GeometricMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Geometric Mean
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <param name="secondValue">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Geometric Mean
        /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Sqrt(firstValue * secondValue);
        }
    }
}