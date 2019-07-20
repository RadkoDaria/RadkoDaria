using calculator.TwoArgumentCalculators;

namespace calculator.TwoArgumentCalculators
{
    /// <summary>
    /// Count arithmetic mean
    /// </summary>
    public class Average : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding arithmetic mean
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <param name="secondValue">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return arithmetic mean
        /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue * secondValue) / 2;
        }
    }
}