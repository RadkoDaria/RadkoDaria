using System;

namespace calculator.TwoArgumentCalculators
{ /// <summary>
  /// Count division
  /// </summary>
    public class Divider : ITwoArgumentsCalculator
    { /// <summary>
      /// Count division
      /// </summary>
      /// <param name="firstValue">
      /// Value of the first parameter
      /// </param>
      /// <param name="secondValue">
      /// Value of the second parameter
      /// </param>
      /// <returns>
      /// Return division
      /// </returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на 0");
            }

            return firstValue / secondValue;
        }
    }
}
