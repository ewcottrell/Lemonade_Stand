using System;
using System.Collections.Generic;

namespace LemonadeStandCompany
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            Console.WriteLine("Welcome to Lemonade Boss Headquarters.");
            Console.WriteLine("What's your name?");
            string ownerName = Console.ReadLine();

            //Create a new instance of a lemonadeCorp
            LemonadeCorporation LemonBoss = new LemonadeCorporation();

            Console.WriteLine($"Well, {ownerName}, since lemonade is our Flagship product, everyone must have at least one lemonade stand.");

            int numberOfLemonadeStands = UserInteraction.GetUserIntegerNumber("So how many lemonade stands do you want to open?");
            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                LemonadeStand stand = new LemonadeStand();
                Console.WriteLine("So what will be the name of Lemonade Stand " + (i + 1) + "?");
                stand.Name = Console.ReadLine();

                Console.WriteLine($"The name of lemonade stand {i + 1} is {stand.Name}.");
                stand.PricePerCup = UserInteraction.GetUserDecimalNumbers($"{ownerName} , what is the price per cup at {stand.Name}?");
                Console.WriteLine($"So PPC or price per cup at {stand.Name} is {stand.PricePerCup}.");
                stand.CostPerCup = UserInteraction.GetUserDecimalNumbers($"What is the cost per cup or cpc at {stand.Name}?");
                LemonBoss.GetTotalDailyPopStandsCosts();
                Console.WriteLine($"So CPC or cost per cup at {stand.Name} is {stand.CostPerCup}.");
                stand.CupsPerDay = UserInteraction.GetUserDecimalNumbers($"Great so how many cups per day do you anticipate selling at {stand.Name}?");
                LemonBoss.GetTotalDailyAdeStandsProfit();
                Console.WriteLine($"The cpd or Cups Per Day at {stand.Name} is {stand.CupsPerDay}.");
                Console.WriteLine($"So if you were to sell {stand.CupsPerDay} cpd at {stand.Name} at {stand.PricePerCup} per cup " +
                                  "your total revenue per day at {stand.Name} will be { stand.TotalDailyRevenue()}");
                LemonBoss.GetTotalDailyAdeStandsRevenue();
                Console.WriteLine();
                Console.WriteLine($"And your total daily cost would be {stand.TotalDailyCost()}");
                Console.WriteLine();
                Console.WriteLine($"which means that your total daily profits will be {stand.TotalDailyProfit()}");

                LemonBoss.AdeStands.Add(stand);
            }
                bool popstandsdesired = UserInteraction.AnsweredYes("Did you want to open any popsickle stands?");
            if (popstandsdesired)
            {
                int numberOfPopsicleStands = UserInteraction.GetUserIntegerNumber($"{ownerName}, how many popsicle stands do you want?");

                for (int i = 0; i < numberOfPopsicleStands; i++)
                {
                    PopsicleStand stand = new PopsicleStand();
                    Console.WriteLine("So what will be the name of Popsicle Stand " + (i + 1) + "?");
                    stand.Name = Console.ReadLine();
                    
                    Console.WriteLine($"Ok the name of popsicle stand {i + 1} is {stand.Name}.");
                    Console.WriteLine();
                    stand.PricePerPop = UserInteraction.GetUserDecimalNumbers($"{ownerName}, what is the price per popsicle at {stand.Name}?");
                    Console.WriteLine($"So PPP or price per pop at {stand.Name} is {stand.PricePerPop}.");
                    stand.CostPerPop = UserInteraction.GetUserDecimalNumbers($"What is the cost per pop or cpp at {stand.Name}?");
                    LemonBoss.GetTotalDailyPopStandsCosts();
                    Console.WriteLine($"So CPP or cost per pop at {stand.Name} is {stand.CostPerPop}.");
                    stand.PopsPerDay = UserInteraction.GetUserDecimalNumbers($"Great so how many pops per day do you anticipate selling at {stand.Name}?");
                    LemonBoss.GetTotalDailyPopStandsProfit();
                    Console.WriteLine($"The ppd or pops Per Day at {stand.Name} is {stand.PopsPerDay}.");
                    Console.WriteLine($"So if you were to sell {stand.PopsPerDay} cpd at {stand.Name} at {stand.PricePerPop} per pop your " +
                                      "total revenue per day at {stand.Name} will be {stand.PopStandTotalDailyRevenue()}");
                    LemonBoss.GetTotalDailyPopStandsRevenue();
                    Console.WriteLine();
                    Console.WriteLine($"And your total daily cost would be {stand.PopStandTotalDailyCost()}");
                    Console.WriteLine();
                    Console.WriteLine($"which means that your total daily profits will be {stand.PopStandTotalDailyProfit()}");
                    LemonBoss.popsicleStands.Add(stand);
                }

            }

            Console.WriteLine("Did you want to open any hotdog stands?");
            // TODO: be able to open hotdog stands

            Console.WriteLine("Total revenue for all lemonade stands is: " + LemonBoss.GetTotalDailyAdeStandsRevenue());
            Console.WriteLine("Total Cost for all lemonade stands is: " + LemonBoss.GetTotalDailyAdeStandsCost());
            Console.WriteLine("Total Profit for all lemonade stands is: " + LemonBoss.GetTotalDailyAdeStandsProfit());
            Console.WriteLine("Total revenue for all popsicle stands is: " + LemonBoss.GetTotalDailyPopStandsRevenue());
            Console.WriteLine("Total cost for all popsicle stands is: " + LemonBoss.GetTotalDailyPopStandsCosts());
            Console.WriteLine("Total profit for all popsicle stands is: " + LemonBoss.GetTotalDailyPopStandsProfit());
            Console.WriteLine("Total Corporate revenue is: " + LemonBoss.GetAllStandsCombinedRevenue());
            Console.WriteLine("Total Corporate Cost is: " + LemonBoss.GetAllStandsCombinedCost());
            Console.WriteLine("Total Corporate Profit is: " + LemonBoss.GetAllStandsCombinedProfit());

            Console.ReadLine();
        }
    }
}
