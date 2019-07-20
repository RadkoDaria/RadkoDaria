namespace calculator.TwoArgumentCalculators
{
    public class Multiplier : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
