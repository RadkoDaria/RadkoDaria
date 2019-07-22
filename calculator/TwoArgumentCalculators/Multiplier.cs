namespace calculator.TwoArgumentCalculators
{
    /// <summary>
    /// Count multiplication
    /// </summary>
    public class Multiplier : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Count multiplication
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <param name="secondValue">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return multiplication
        /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
