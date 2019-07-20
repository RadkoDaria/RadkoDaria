using System;
using calculator.OneArgumentCalculators;

namespace calculator.OneArgumentCalculators
{
    /// <summary>
    /// Count Radians
    /// </summary>
    public class Radians : IOneArgumentCalculator
    {
   
        /// <summary>
        /// Finding Radians
        /// </summary>
        /// <param name="firstValue">
        /// Value in degrees
        /// </param>
        /// <returns>
        /// Result in radians
        /// </returns>
        public double Calculate(double firstValue)
        {
            return firstValue * (Math.PI / 180);
        }
    }
}
