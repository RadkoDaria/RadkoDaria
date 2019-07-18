namespace calculator.TwoArgumentCalculators
{
    public class Divider : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}
