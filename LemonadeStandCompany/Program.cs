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

            Console.WriteLine("How many lemonade stands do you want to open?");
            int numberOfLemonadeStands = int.Parse(Console.ReadLine());

            int number = 0;
            List<string> standNames = new List<string>();
            for (int i = 0; i < numberOfLemonadeStands; i++)
            {
                number++;
                Console.WriteLine("So what will the name of Lemonade Stand " + number);
                string userStandNames = Console.ReadLine();
                standNames.Add(userStandNames);



            }

            Console.ReadLine();
        }
    }
}
