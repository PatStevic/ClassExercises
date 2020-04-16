using System;

namespace Exercise6
{
    class Program
    {
        static string tesetResponse = ""; 

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Would you like to continue y/n");
                string userResponse = Console.ReadLine();
                tesetResponse = userResponse; 
            } while (tesetResponse == "y");
        }
    }
}
