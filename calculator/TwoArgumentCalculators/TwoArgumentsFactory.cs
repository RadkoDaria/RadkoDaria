using System;


namespace calculator.TwoArgumentCalculators
{
   public static class TwoArgumentsFactory
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
                   return  new Multiplier();
                case "div":
                    return  new Divider();
                case "aver":
                    return new Average();
                case "XExpY":
                    return new Exponentiation();
                case "GeoMean":
                    return new GeometricMean();
                case "Min":
                    return new Min();
                case "Max":
                    return new Max();
                case "sqr":
                    return new RootExtraction();
                default: throw new Exception("Неопределенная операция");
            }
        }
    }
}
