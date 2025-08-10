using System;

namespace FinancialForecastingTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Financial Forecasting Tool!");

            Console.Write("Enter initial amount: ");
            double initialAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter annual growth rate (in %): ");
            double growthRate = Convert.ToDouble(Console.ReadLine()) / 100.0;

            Console.Write("Enter number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            ForecastCalculator calculator = new ForecastCalculator();

            double futureValue = calculator.CalculateFutureValueRecursive(initialAmount, growthRate, years);

            Console.WriteLine($"\nPredicted value after {years} years: {futureValue:F2}");
        }
    }
}
