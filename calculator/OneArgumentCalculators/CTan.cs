using System;
using calculator.OneArgumentCalculators;

namespace calculator.OneArgumentCalculators
{
    /// <summary>
    /// Count CTan
    /// </summary>
    public class CTan : IOneArgumentCalculator
    {


        /// <summary>
        /// Finding CTan
        /// </summary>
        /// <param name="firstValue">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// CTan results in radians
        /// </returns>
        public double Calculate(double firstValue)
        {
            return 1 / Math.Tan(firstValue);
        }
    }
}
