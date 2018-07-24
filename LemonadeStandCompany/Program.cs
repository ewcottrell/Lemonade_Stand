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


            //Create a new instance of a lemonadeCorp
            LemonadeCorporation LemonBoss = new LemonadeCorporation();

            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                LemonadeStand stand = new LemonadeStand();
                Console.WriteLine("So what will be the name of Lemonade Stand " + (i + 1) + "?");
                stand.Name = Console.ReadLine();

                Console.WriteLine("The name of lemonade stand " + (i + 1) + " is " + stand.Name
                                 + ".");
                Console.WriteLine(ownerName + " What is the price per cup at " + stand.Name + "?");
                stand.PricePerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("So PPC or price per cup at " + stand.Name + " is " + stand.PricePerCup + ".");
                Console.WriteLine("What is the cost per cup or cpc at " + stand.Name + "?");
                stand.CostPerCup = decimal.Parse(Console.ReadLine());
                LemonBoss.GetCorpTotalDailyCost();
                Console.WriteLine("So CPC or cost per cup at " + stand.Name + " is " + stand.CostPerCup + ".");

                Console.WriteLine("Great so how many cups per day do you anticipate " +
                                  "selling at " + stand.Name + "?");
                stand.CupsPerDay = decimal.Parse(Console.ReadLine());
                LemonBoss.GetCorpTotalDailyProfit();
                Console.WriteLine("The cpd or Cups Per Day at " + stand.Name + " is " + stand.CupsPerDay + ".");
                Console.WriteLine("So if you were to sell " + stand.CupsPerDay + " cpd at " + stand.Name
                                  + " at " + stand.PricePerCup + " per cup " +
                                  " your total revenue per day at " + stand.Name
                                  + " will be " + stand.TotalDailyRevenue());
                LemonBoss.GetCorpTotalDailyRevenue();
                Console.WriteLine();
                Console.WriteLine("And your total daily cost would be " + stand.TotalDailyCost());
                Console.WriteLine();
                Console.WriteLine("which means that your total daily profits will be " + stand.TotalDailyProfit());

                LemonBoss.Locations.Add(stand);
            }
            Console.WriteLine("Did you want to open any popsickle stands?");
            string popstandsdesired = Console.ReadLine();
            if (popstandsdesired == "yes")
                Console.WriteLine(ownerName + " how many popsickle stands do you want?"); 
            

            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                LemonadeStand stand = new LemonadeStand();
                Console.WriteLine("So what will be the name of Lemonade Stand " + (i + 1) + "?");
                stand.Name = Console.ReadLine();

                Console.WriteLine("The name of lemonade stand " + (i + 1) + " is " + stand.Name
                                 + ".");
                Console.WriteLine(ownerName + " What is the price per cup at " + stand.Name + "?");
                stand.PricePerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("So PPC or price per cup at " + stand.Name + " is " + stand.PricePerCup + ".");
                Console.WriteLine("What is the cost per cup or cpc at " + stand.Name + "?");
                stand.CostPerCup = decimal.Parse(Console.ReadLine());
                LemonBoss.GetCorpTotalDailyCost();
                Console.WriteLine("So CPC or cost per cup at " + stand.Name + " is " + stand.CostPerCup + ".");

                Console.WriteLine("Great so how many cups per day do you anticipate " +
                                  "selling at " + stand.Name + "?");
                stand.CupsPerDay = decimal.Parse(Console.ReadLine());
                LemonBoss.GetCorpTotalDailyProfit();
                Console.WriteLine("The cpd or Cups Per Day at " + stand.Name + " is " + stand.CupsPerDay + ".");
                Console.WriteLine("So if you were to sell " + stand.CupsPerDay + " cpd at " + stand.Name
                                  + " at " + stand.PricePerCup + " per cup " +
                                  " your total revenue per day at " + stand.Name
                                  + " will be " + stand.TotalDailyRevenue());
                LemonBoss.GetCorpTotalDailyRevenue();
                Console.WriteLine();
                Console.WriteLine("And your total daily cost would be " + stand.TotalDailyCost());
                Console.WriteLine();
                Console.WriteLine("which means that your total daily profits will be " + stand.TotalDailyProfit());

                LemonBoss.Locations.Add(stand);
            }
            Console.WriteLine("Did you want to open any hotdog stands?");


            Console.WriteLine("Total Corp revenue is: " + LemonBoss.GetCorpTotalDailyRevenue());
            Console.WriteLine("Total Corp Cost is: " + LemonBoss.GetCorpTotalDailyCost());
            Console.WriteLine("Total Corp Profit is: " + LemonBoss.GetCorpTotalDailyProfit());


            Console.ReadLine();
        }
    }
}
