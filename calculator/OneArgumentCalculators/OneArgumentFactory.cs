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
                default: throw new Exception("Неопределенная операция");
            }
        }
    }
}
