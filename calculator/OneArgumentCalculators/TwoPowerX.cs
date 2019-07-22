using System;

namespace calculator.OneArgumentCalculators
{/// <summary>
 /// raising 2 to the power
 /// </summary>
    public class TwoPowerX : IOneArgumentCalculator
     
    {/// <summary>
     /// raising 2 to the power
     /// </summary>
     /// <param name="firstValue">
     /// Value of the first parameter 
     /// </param>
     /// <returns>
     /// raising 2 to the power
     /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}
