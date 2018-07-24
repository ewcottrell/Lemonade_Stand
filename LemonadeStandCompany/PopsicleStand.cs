using System;
namespace LemonadeStandCompany
{
    public class PopsicleStand
    {

        public string Name { get; set; }
        public decimal PopsPerDay { get; set; }
        public decimal CostPerPop { get; set; }
        public decimal PricePerPop { get; set; }

        public decimal PopStandTotalDailyRevenue()
        {
            return PopsPerDay * PricePerPop;
        }

        public decimal PopStandTotalDailyCost()
        {
            return PopsPerDay * CostPerPop;
        }

        public decimal PopStandTotalDailyProfit()
        {
            return PopStandTotalDailyRevenue() - PopStandTotalDailyCost();

        }
    }
}
