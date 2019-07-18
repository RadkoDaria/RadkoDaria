using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.OneArgumentCalculators;

namespace calculator.OneArgumentCalculators
{
    public class Ln :IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(firstValue);
        }
    }
}
