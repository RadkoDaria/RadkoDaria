using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalculators
{
    public class Log10 : IOneArgumentCalculator

    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}
