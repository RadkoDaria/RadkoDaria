using System;

namespace calculator.OneArgumentCalculators
{ 
    /// <summary>
    /// Count SquareRoot
    /// </summary>
    public class SquareRoot : IOneArgumentCalculator
    {
        /// <summary>
        /// Finding SquareRoot
        /// </summary>
        /// <param name="firstValue">
        /// Value of the parameter
        /// </param>
        /// <returns>
        /// SquareRoot results
        /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Sqrt(firstValue);
        }
    }
}