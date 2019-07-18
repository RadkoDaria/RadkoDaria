namespace calculator.TwoArgumentCalculators
{
    public class Multiplyer : ITwoArgumentsCalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
