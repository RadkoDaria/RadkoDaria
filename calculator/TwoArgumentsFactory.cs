using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
   public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "add":
                    return new Adder();
                case "sub":
                    return new Subtracter();
                case "mult":
                   return  new Multiplyer();
                case "div":
                    return  new Divider();
                default: throw new Exception("Неопределенная операция");
            }
        }
    }
}
