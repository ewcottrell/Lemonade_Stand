using System;
using System.Linq;

namespace LemonadeStandCompany
{
    public class UserInteraction
    {
        public static int GetUserIntegerNumber(string question)
        {
            Console.WriteLine(question);
            bool isANumber = int.TryParse(Console.ReadLine(), out int number);

            while (!isANumber)
            {
                Console.WriteLine("Not a number. " + question);
                isANumber = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        public static decimal GetUserDecimalNumbers(string question)
        {
            Console.WriteLine(question);

            decimal number;
            while (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Not a number. " + question);
            }
            return number;
        }

        public static bool AnsweredYes(string question)
        {
            string[] yesOption = { "YES", "YEAH", "Y", "YEP", "YUP" };
            Console.WriteLine(question);
            return yesOption.Contains(Console.ReadLine().ToUpper());
        }
    }
}
