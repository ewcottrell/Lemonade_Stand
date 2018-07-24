using System;
using System.Collections.Generic;
namespace LemonadeStandCompany
{
    public class LemonadeCorporation
    {
        public string Name { get; set; }
        public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();
        public List<PopsicleStand> popsicleStands { get; set; } = new List<PopsicleStand>();


        public decimal GetCorpTotalDailyRevenue()
        {
            decimal grandTotalRev = 0;
            foreach (LemonadeStand location in Locations)
            {
                grandTotalRev += location.TotalDailyRevenue();
            }
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalRev += PopStand.PopStandTotalDailyRevenue();
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
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalCost += PopStand.PopStandTotalDailyCost();
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
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalProfit += PopStand.PopStandTotalDailyProfit();
            }
            return grandTotalProfit;
        }

    }
}
