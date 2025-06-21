namespace FinancialForecasting
{
    using System;

    class FinancialForecast
    {
        static double CalculateFutureValue(double initialValue, double growthRate, int years)
        {
            if (years==0)
                return initialValue;

            return CalculateFutureValue(initialValue, growthRate, years-1) * (1+growthRate);
        }

        static void Main(string[] args){
            double initialValue = 10000;
            double growthRate = 0.05;
            int years = 10;

            double futureValue = CalculateFutureValue(initialValue, growthRate, years);
            Console.WriteLine($"Future Value after {years} years: {futureValue:C}");
        }
    }
}
