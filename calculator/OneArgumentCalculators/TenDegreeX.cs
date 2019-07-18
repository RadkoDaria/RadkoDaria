using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalculators
{
    public class TenDegreeX : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(10, firstValue);
        }
    }
}
