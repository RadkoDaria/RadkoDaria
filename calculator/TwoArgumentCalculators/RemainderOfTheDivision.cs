namespace calculator.TwoArgumentCalculators
{
    /// <summary>
    /// Count Remainder Of The Division
    /// </summary>
    public class RemainderOfTheDivision : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Finding Remainder Of The Division
        /// </summary>
        /// <param name="firstValue">
        /// Value of the first parameter
        /// </param>
        /// <param name="secondValue">
        /// Value of the second parameter
        /// </param>
        /// <returns>
        /// Return Remainder Of The Division
        /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}