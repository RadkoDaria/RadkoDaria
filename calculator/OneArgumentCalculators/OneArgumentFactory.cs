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


                default: throw new Exception("Неопределенная операция");
            }
        }
    }
}
