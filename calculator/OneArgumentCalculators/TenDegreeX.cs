using System;

namespace calculator.OneArgumentCalculators
{/// <summary>
 /// raising 10 to the power
 /// </summary>
    public class TenDegreeX : IOneArgumentCalculator
    {/// <summary>
     /// raising 10 to the power
     /// </summary>
     /// <param name="firstValue">
     /// Value of the first parameter 
     /// </param>
     /// <returns>
     /// raising 10 to the power
     /// </returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(10, firstValue);
        }
    }
}
