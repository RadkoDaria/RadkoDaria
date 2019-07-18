using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalculators
{
    public class TwoPowerX : IOneArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}
