namespace FinancialForecastingTool
{
    public class ForecastCalculator
    {
       
        public double CalculateFutureValueRecursive(double amount, double rate, int years)
        {
            if (years == 0)
                return amount;

            return CalculateFutureValueRecursive(amount, rate, years - 1) * (1 + rate);
        }

       
        public double CalculateFutureValueIterative(double amount, double rate, int years)
        {
            double result = amount;
            for (int i = 1; i <= years; i++)
            {
                result *= (1 + rate);
            }
            return result;
        }
    }
}
