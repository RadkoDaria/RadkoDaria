using System;

namespace calculator.OneArgumentCalculators
{/// <summary>
    /// raising Exp to the power
    /// </summary>
    public class Exp:IOneArgumentCalculator
    {/// <summary>
        /// raising Exp to the power
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter 
        /// </param>
        /// <returns>
        /// raising Exp to the power
        /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
