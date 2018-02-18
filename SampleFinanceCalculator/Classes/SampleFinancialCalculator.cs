using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFinancialCalculator.Classes
{
    public class Calculator
    {
        public double CalculateCost(DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDates = new List<DateTime>();
            double itemCost = 0;
            double totalCost = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                allDates.Add(date);
            }
            foreach (DateTime date in allDates)
            {
                if (date.Day <= 7 && (date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday))
                {
                    itemCost = .05;
                    totalCost += itemCost;
                }
                else if (date.Day > 7 && date.Day <= 14 && (date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday))
                {
                    itemCost = .10;
                    totalCost += itemCost;
                }
                else if (date.Day > 14 && date.Day <= 21 && (date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday))
                {
                    itemCost = .15;
                    totalCost += itemCost;
                }
                else if (date.Day > 21 && date.Day <= 28 && (date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday))
                {
                    itemCost = .20;
                    totalCost += itemCost;
                }
                else if (date.Day > 28 && date.Day <= 31 && (date.DayOfWeek != DayOfWeek.Saturday) && (date.DayOfWeek != DayOfWeek.Sunday))
                {
                    itemCost = .25;
                    totalCost += itemCost;
                }

            }
            return totalCost;

        }
    }
}
