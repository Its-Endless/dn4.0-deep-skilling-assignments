using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("📈 Financial Forecasting Tool");

            Console.Write("Enter Initial Amount: ");
            double initialAmount = double.Parse(Console.ReadLine());

            Console.Write("Enter Annual Growth Rate (e.g., 0.05 for 5%): ");
            double growthRate = double.Parse(Console.ReadLine());

            Console.Write("Enter Number of Years: ");
            int years = int.Parse(Console.ReadLine());

            double futureValue = CalculateFutureValue(initialAmount, growthRate, years);

            Console.WriteLine($"\n💰 Future Value after {years} years: {futureValue:F2}");
        }

        // 🔁 Recursive Method
        static double CalculateFutureValue(double initialAmount, double growthRate, int years)
        {
            if (years == 0)
                return initialAmount;

            return CalculateFutureValue(initialAmount, growthRate, years - 1) * (1 + growthRate);
        }
    }
}
