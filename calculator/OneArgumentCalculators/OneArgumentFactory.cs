using System;

namespace calculator.OneArgumentCalculators
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tan":
                    return new Tan();
                case "Ln":
                    return new Ln();
                case "Exp":
                    return new Exp();
                case "Arcsin":
                    return new Arcsin();
                case "Arccos":
                    return new Arccos();
                case "Log10":
                    return new Log10();
                case "Log2":
                    return new Log2();
                case "Degree2":
                    return new Degree2();
                case "TwoPowerX":
                    return new TwoPowerX();
                case "CTan":
                    return new CTan();
                case "Radians":
                    return new Radians();
                case "TenDegreeX":
                    return new TenDegreeX();



                default: throw new Exception("Неопределенная операция");
            }
        }
    }
}
