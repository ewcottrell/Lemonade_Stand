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

            Console.WriteLine(ownerName +" how many lemonade stands do you want to open?");
            int numberOfLemonadeStands = int.Parse(Console.ReadLine());

            int number = 1;
            List<string> standNames = new List<string>();
            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                Console.WriteLine("So what will be the name of Lemonade Stand " + number + "?");
                string userStandNames = Console.ReadLine();
                standNames.Add(userStandNames);

                Console.WriteLine("The name of lemonade stand " + number + " is " + userStandNames
                                 + ".");
                Console.WriteLine(ownerName + " What is the price per cup at lemonade stand " + number + "?");

                decimal pricePerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("So PPC or price per cup at lemonade stand " + number
                                  + " is " + pricePerCup + ".");

                Console.WriteLine("What is the cost per cup or cpc at lemonade stand " + number + "?");
                decimal costPerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("So CPC or cost per cup at lemonade stand " + number
                                  + " is " + costPerCup + ".");

                Console.WriteLine("Great so how many cups per day do you anticipate " +
                                  "selling at lemonade stand " + number + "?");
                decimal cupPerDay = decimal.Parse(Console.ReadLine());

                Console.WriteLine("The cpd or Cups Per Day at lemonade stand " + number 
                                  + " is " + cupPerDay +".");

                Console.WriteLine("So if you were to sell " + cupPerDay + " cpd at lemonade stand " 
                                  + number + " at " + pricePerCup + " per cup " + 
                                  " your total revenue per day at lemonade stand " + number
                                  + " will be " + (cupPerDay * pricePerCup));
                number++;
            }

            Console.ReadLine();
        }
    }
}
