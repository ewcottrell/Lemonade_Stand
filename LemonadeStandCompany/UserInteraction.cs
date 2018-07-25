using System;
namespace LemonadeStandCompany
{
    public class UserInteraction
    {
        public static int GetUserIntegerNumber(string question)
        {
            int number;
            Console.WriteLine(question);
            bool isANumber = int.TryParse(Console.ReadLine(), out number);

            while (isANumber == false)
            {
                Console.WriteLine("Not a number  " + question);
                isANumber = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        public static decimal GetUserDecimalNumbers(string question)
        {
            decimal number;
            Console.WriteLine(question);
            bool isANumber = decimal.TryParse(Console.ReadLine(), out number);

            while (isANumber == false)
            {
                Console.WriteLine("Not a number  " + question);
                isANumber = decimal.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        public static bool AnsweredYes(string question)
        {
            string[] yesOption = { "YES", "YEAH", "Y", "YEP", "YUP" };
            Console.WriteLine(question);
            string response = Console.ReadLine();

            foreach (string option in yesOption)
            {
                if (option == response.ToUpper())
                {
                    return true; 
                }
            }

            return false;
        }
    }
}
