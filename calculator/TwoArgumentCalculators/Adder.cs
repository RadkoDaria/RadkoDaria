namespace calculator.TwoArgumentCalculators
{
    public class Adder : ITwoArgumentsCalculator

    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
