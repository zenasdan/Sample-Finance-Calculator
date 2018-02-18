using SampleFinancialCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFinancialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a start and end date: ");
            Console.WriteLine("Start Date:");
            Console.Write("Year: ");
            var startYear = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            var startMonth = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            var startDay = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnd Date:");
            Console.Write("Year: ");
            var endYear = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            var endMonth = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            var endDay = int.Parse(Console.ReadLine());

            Calculator calcObj = new Calculator();

            var totalCost = calcObj.CalculateCost(new DateTime(startYear, startMonth, startDay), new DateTime(endYear, endMonth, endDay));

            Console.WriteLine($"\nThe total cost of items between these dates is: {totalCost}");

            Console.ReadLine();
        }
    }
}
