using System;
namespace LemonadeStandCompany
{
    public class LemonadeStand
    {
        
        public string Name { get; set;  }
        public decimal CupsPerDay { get; set; }
        public decimal CostPerCup { get; set; }
        public decimal PricePerCup { get; set; }

        public decimal TotalDailyRevenue()
        {
            return CupsPerDay * PricePerCup;
        }

        public decimal TotalDailyCost()
        {
            return CupsPerDay * CostPerCup;
        }

        public decimal TotalDailyProfit()
        {
            return TotalDailyRevenue() - TotalDailyCost();
           
        }


       

    }
}
