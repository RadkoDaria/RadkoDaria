namespace calculator.TwoArgumentCalculators
{
    public class Subtracter : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
