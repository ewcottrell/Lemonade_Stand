using System;
using System.Collections.Generic;

namespace LemonadeStandCompany
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("Welcome to Lemonade Stand Headquarters.");
            Console.WriteLine("What's your name?");
            string ownerName = Console.ReadLine();

            Console.WriteLine(ownerName + " how many lemonade stands do you want to open?");
            int numberOfLemonadeStands = int.Parse(Console.ReadLine());

            int number = 1;
            //Create a new instance of a lemonadeCorp
            LemonadeCorporation corporation = new LemonadeCorporation();
            decimal CorpCupsPerDay = 0;
            decimal CorpPricePerCup = 0;
            decimal CorpCostPerCup = 0;
            decimal AvgCorpPricePerCup = CorpPricePerCup / numberOfLemonadeStands;
            decimal corpTotalRevenue = 0;
            //Create a list of lemonade Stands called standNames
            List<LemonadeStand> standNames = new List<LemonadeStand>();
            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                LemonadeStand stand = new LemonadeStand();
                Console.WriteLine("So what will be the name of Lemonade Stand " + number + "?");
                stand.Name = Console.ReadLine();
                standNames.Add(stand); //Adds the newly created stand to the list

                Console.WriteLine("The name of lemonade stand " + number + " is " + stand.Name
                                 + ".");
                Console.WriteLine(ownerName + " What is the price per cup at " + stand.Name + "?");
                stand.PricePerCup = decimal.Parse(Console.ReadLine());
                CorpPricePerCup += stand.PricePerCup;
                Console.WriteLine("So PPC or price per cup at " + stand.Name + " is " + stand.PricePerCup + ".");
                Console.WriteLine("What is the cost per cup or cpc at " + stand.Name + "?");
                stand.CostPerCup = decimal.Parse(Console.ReadLine());
                CorpCostPerCup += stand.CostPerCup;
                Console.WriteLine("So CPC or cost per cup at " + stand.Name + " is " + stand.CostPerCup + ".");

                Console.WriteLine("Great so how many cups per day do you anticipate " +
                                  "selling at " + stand.Name + "?");
                stand.CupsPerDay = decimal.Parse(Console.ReadLine());
                CorpCupsPerDay += stand.CupsPerDay;
                Console.WriteLine("The cpd or Cups Per Day at " + stand.Name + " is " + stand.CupsPerDay + ".");
                Console.WriteLine("So if you were to sell " + stand.CupsPerDay + " cpd at " + stand.Name
                                  + " at " + stand.PricePerCup + " per cup " +
                                  " your total revenue per day at " + stand.Name
                                  + " will be " + stand.TotalDailyRevenue());
                corpTotalRevenue += stand.TotalDailyRevenue();
                Console.WriteLine();
                Console.WriteLine("And your total daily cost would be " + stand.TotalDailyCost());
                Console.WriteLine();
                Console.WriteLine("which means that your total daily profits will be " + stand.TotalDailyProfit());
                number++;
            }
            corporation.adeStands = standNames;
            Console.WriteLine(CorpCupsPerDay);
            Console.WriteLine(corpTotalRevenue);
            Console.ReadLine();
        }
    }
}
