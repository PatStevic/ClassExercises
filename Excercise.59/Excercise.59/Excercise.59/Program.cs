using System;
using System.Collections.Generic;

namespace Excercise._59
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue;
            do
            { 
            var deck = new List<Cards>();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    deck.Add(new Cards((Rank)j, (Suite)i));
                }
            }

            Random random = new Random(); 
            int randomGeneratedNumber = random.Next(0,52);

            Console.WriteLine($"{deck[randomGeneratedNumber].Rank} of {deck[randomGeneratedNumber].Suite}");
            Console.WriteLine("Would you like to continue? (y/n)");
            userWantsToContinue = Console.ReadLine();
            }
            while (userWantsToContinue.ToLower() == "y");
        }
    }
}
