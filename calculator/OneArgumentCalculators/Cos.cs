using System;

namespace calculator.OneArgumentCalculators
{
    /// <summary>
    /// Count Cos
    /// </summary>
    public class Cos :IOneArgumentCalculator
    {
        /// <summary>
        /// Count Cos
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <returns>
        /// Cos results in radians
        /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
