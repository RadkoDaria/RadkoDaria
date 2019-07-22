using System;

namespace calculator.OneArgumentCalculators
{/// <summary>
 /// Raising the number to the power 2
 /// </summary>
    public class Degree2 : IOneArgumentCalculator
    {
        /// <summary>
        /// Raising the number to the power 2
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter 
        /// </param>
        /// <returns>
        /// result of raising the number to the power of 2
        /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(firstValue, 2);
        }
    }
}
