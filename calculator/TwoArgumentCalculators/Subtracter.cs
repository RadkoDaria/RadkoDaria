namespace calculator.TwoArgumentCalculators
{/// <summary>
 /// Count subtraction
    /// </summary>
    public class Subtracter : ITwoArgumentsCalculator
    {/// <summary>
     /// Count subtraction
     /// </summary>
     /// <param name="firstValue">
     /// Value of the first parameter
     /// </param>
     /// <param name="secondValue">
     /// Value of the second parameter
     /// </param>
     /// <returns>
     /// Return subtraction
     /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
