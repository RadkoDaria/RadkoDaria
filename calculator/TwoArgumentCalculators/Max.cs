using System;

namespace calculator.TwoArgumentCalculators
{
    /// <summary>
    /// Count Maximum
    /// </summary>
    public class Max : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Maximum
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <param name="secondValue">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Maximum
        /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}