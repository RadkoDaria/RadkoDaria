using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalculators
{
    public class Log2 : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(firstValue, 2); 
        }
    }
}
