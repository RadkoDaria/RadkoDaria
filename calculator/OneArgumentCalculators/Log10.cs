using System;

namespace calculator.OneArgumentCalculators
{/// <summary>
    /// Count Log10
    /// </summary>
    public class Log10 : IOneArgumentCalculator
    /// <summary>
    /// Finding Log10
    /// </summary>
    /// <param name="firstValue">
    /// </param>
    /// <returns>
    /// Result log10
    /// </returns>
    {
        public double Calculate(double firstValue)
        {
            if (firstValue <= 0)
            {
                throw new Exception("Аргумент должен быть > 0 ");
            }
            return Math.Log10(firstValue);
        }
    }
}
