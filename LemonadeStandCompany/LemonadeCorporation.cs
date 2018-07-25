using System;
using System.Collections.Generic;
namespace LemonadeStandCompany
{
    public class LemonadeCorporation
    {
        public string Name { get; set; }
        public List<LemonadeStand> AdeStands { get; set; } = new List<LemonadeStand>();
        public List<PopsicleStand> popsicleStands { get; set; } = new List<PopsicleStand>();

        //next 3 methods get total daily rev, cost, and profit for all stands
        public decimal GetTotalDailyAdeStandsRevenue()
        {
            decimal grandTotalAdeStandRev = 0;
            foreach (LemonadeStand stand in AdeStands )
            {
                grandTotalAdeStandRev += stand.TotalDailyRevenue();
            }
           
            return grandTotalAdeStandRev;
        }

        public decimal GetTotalDailyAdeStandsCost()
        {
            decimal grandTotalAdeStandCost = 0;
            foreach (LemonadeStand stand in AdeStands)
            {
                grandTotalAdeStandCost += stand.TotalDailyCost();
            }
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalAdeStandCost += PopStand.PopStandTotalDailyCost();
            }
            return grandTotalAdeStandCost;
        }

        public decimal GetTotalDailyAdeStandsProfit()
        {
            decimal grandTotalAdeStandProfit = 0;
            foreach (LemonadeStand stand in AdeStands)
            {
                grandTotalAdeStandProfit += stand.TotalDailyProfit();
            }
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalAdeStandProfit += PopStand.PopStandTotalDailyProfit();
            }
            return grandTotalAdeStandProfit;
        }

        public decimal GetTotalDailyPopStandsRevenue()
        {
            decimal grandTotalPopStandRev = 0;
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalPopStandRev += PopStand.PopStandTotalDailyRevenue();
            }
            return grandTotalPopStandRev;
        }

        public decimal GetTotalDailyPopStandsCosts()
        {
            decimal grandTotalPopStandCost = 0;
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalPopStandCost += PopStand.PopStandTotalDailyCost();
            }
            return grandTotalPopStandCost;
        }
        public decimal GetTotalDailyPopStandsProfit()
        {
            decimal grandTotalPopStandsProfits = 0;
            foreach (PopsicleStand PopStand in popsicleStands)
            {
                grandTotalPopStandsProfits += PopStand.PopStandTotalDailyRevenue();
            }
            return grandTotalPopStandsProfits;
        }

        public decimal GetAllStandsCombinedRevenue()
        {
            return GetTotalDailyAdeStandsRevenue() + GetTotalDailyPopStandsRevenue();
        }

        public decimal GetAllStandsCombinedCost()
        {
            return GetTotalDailyAdeStandsCost() + GetTotalDailyPopStandsCosts();
        }

        public decimal GetAllStandsCombinedProfit()
        {
            return GetAllStandsCombinedRevenue() - GetAllStandsCombinedCost();
        }
    }
}
