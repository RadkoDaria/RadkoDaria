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
            if (firstValue < 0)
            {
                throw new Exception("Аргумент должен быть > 0 ");
            }
            return Math.Sqrt(firstValue);
        }
    }
}