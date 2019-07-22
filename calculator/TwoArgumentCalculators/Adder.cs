namespace calculator.TwoArgumentCalculators
{ /// <summary>
  /// addition operation
  /// </summary>
    public class Adder : ITwoArgumentsCalculator

    { /// <summary>
      /// addition operation
      /// </summary>
      /// <param name="firstValue">
      /// Value of the first parameter
      /// </param>
      /// <param name="secondValue">
      /// Value of the second parameter
      /// </param>
      /// <returns>
      /// Return addition operation
      /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
