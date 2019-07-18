using System;

namespace calculator.TwoArgumentCalculators
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
