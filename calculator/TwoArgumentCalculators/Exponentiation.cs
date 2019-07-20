using System;

namespace calculator.TwoArgumentCalculators
{
    /// <summary>
    /// Count Exponentiation
    /// </summary>
    public class Exponentiation : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Exponentiation
        /// </summary>
        /// <param name="firstValue">
        /// Number raised to the power
        /// </param>
        /// <param name="secondValue">
        /// Degree of
        /// </param>
        /// <returns>
        /// Exponentiation results
        /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}