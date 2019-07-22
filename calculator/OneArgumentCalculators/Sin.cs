using System;

namespace calculator.OneArgumentCalculators
{
    /// <summary>
    /// Count Sin
    /// </summary>

    public class Sin :IOneArgumentCalculator
    {
        /// <summary>
        /// Finding Sin
        /// </summary>
        /// <param name="firstValue">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// Sin results in radians
        /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
    }
}
