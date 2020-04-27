using System;

namespace LabNumber._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string wouldTheUserLikeToGoAgain;

            do
            {
                bool validNumberForDiceNumberOne;
                bool validNumberForDiceNumberTwo;
                int diceNumberForDiceOne;
                int diceNumberForDiceTwo;

                do
                {
                    Console.Write("Let's role some dice. Pick two dice, how many sides does each of the dice have?\nDice one (enter value):");
                    validNumberForDiceNumberOne = int.TryParse(Console.ReadLine(), out diceNumberForDiceOne);
                    Console.Write("Dice two (enter value):");
                    validNumberForDiceNumberTwo = int.TryParse(Console.ReadLine(), out diceNumberForDiceTwo); ;

                    if (!validNumberForDiceNumberOne || !validNumberForDiceNumberTwo)
                    {
                        Console.WriteLine("\n\nOne or both of the dice did not have a valid number. Please try again.\n\n");
                    }

                } while (!validNumberForDiceNumberOne || !validNumberForDiceNumberTwo);

                var random = new Random();
                var randomDiceOne = random.Next(1, diceNumberForDiceOne);
                var randomDiceTwo = random.Next(1, diceNumberForDiceTwo);



                Console.WriteLine($"\n\nHere comes the roll!!! The dice stop at!\n\nDice One:{randomDiceOne}\nDice Two: {randomDiceTwo}"); 

                Console.WriteLine("\nWould you like to go again?(Type Y/N)");
                wouldTheUserLikeToGoAgain = Console.ReadLine();

                
            } while (wouldTheUserLikeToGoAgain.ToLower() == "y");

        }
    }
}
