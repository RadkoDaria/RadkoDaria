using System;

namespace calculator.OneArgumentCalculators
{ /// <summary>
  /// Count the square root
  /// </summary>
  
    public class SquareRoot : IOneArgumentCalculator
    {/// <summary>
     /// Finding the square root
     /// </summary>
     /// <param name="firstValue">
     /// Value of the first parameter
     /// </param>
     /// <returns>
     /// Return square root
     /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Sqrt(firstValue);
        }
    }
}