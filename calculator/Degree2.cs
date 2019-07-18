using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgumentCalculators
{
   public class Degree2
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(firstValue, 2);
        }
    }
}
