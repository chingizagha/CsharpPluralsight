using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            void GetPercentage(double surveyed, double responded)
            {
                var respondedPercentage = (100 * responded) / surveyed;
                var notResponded = surveyed - responded;

                double overallScore = (Q1Results.ServiceScore + Q1Results.PriceScore + Q1Results.FoodScore + Q1Results.CoffeeScore) / 4;

                Console.WriteLine($"Percentage of responders: {respondedPercentage:N1}%");
                Console.WriteLine($"Number of unanswered: {notResponded}");
                Console.WriteLine($"Overall score of caffee: {overallScore}");
            }

            var list = new List<string>();

            GetPercentage(Q1Results.NumberSurveyed, Q1Results.NumberResponded);
        }
    }
}
