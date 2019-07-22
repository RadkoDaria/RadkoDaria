using System;

namespace calculator.OneArgumentCalculators
{
    /// <summary>
    /// Count Arccos
    /// </summary>
    public class Arccos : IOneArgumentCalculator
    {
        /// <summary>
        /// Count Arccos
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <returns>
        /// Arccos results in radians
        /// </returns>
        public double Calculate(double firstValue)
        {
            if (firstValue > 1 || firstValue < -1)
            {
                throw new Exception("Ограничения arccos");
            }
            return Math.Acos(firstValue);
        }
    }
}
