using System;

namespace Excercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse;
            do
            {
                Console.WriteLine("Hello World! ECHOOOOOO!");
                Console.WriteLine("Would you like to continue y/n");
                userResponse = Console.ReadLine();
            } while (userResponse == "y");

            Console.WriteLine("Goodbye");

        }
    }
}
