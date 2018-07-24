using System;
using System.Collections.Generic;
namespace LemonadeStandCompany
{
    public class LemonadeCorporation
    {
        public string Name { get; set; }
        public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();


        public decimal GetCorpTotalDailyRevenue()
        {
            decimal grandTotalRev = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotalRev += location.TotalDailyRevenue();
            }
            return grandTotalRev;
        }

        public decimal GetCorpTotalDailyCost()
        {
            decimal grandTotalCost = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotalCost += location.TotalDailyCost();
            }
            return grandTotalCost;
        }

        public decimal GetCorpTotalDailyProfit()
        {
            decimal grandTotalProfit = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotalProfit += location.TotalDailyProfit();
            }
            return grandTotalProfit;
        }

    }
}
