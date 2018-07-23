using System;
using System.Collections.Generic;
namespace LemonadeStandCompany
{
    public class LemonadeCorporation
    {
        public List<LemonadeStand> adeStands { get; set; }

        public decimal CorpCupsPerDay { get; set; }
        public decimal CorpCostPerCup { get; set; }
        public decimal CorpPricePerCup { get; set; }

        public decimal CorpTotalDailyRevenue(decimal CorpCupsPerDay, decimal CorpPricePerCup)
        {
            return CorpCupsPerDay * CorpPricePerCup;
        }

        public decimal CorpTotalDailyCost(decimal CorpCupsPerDay, decimal CorpCostPerCup)
        {
            return CorpCupsPerDay * CorpCostPerCup;
        }




    }
}
