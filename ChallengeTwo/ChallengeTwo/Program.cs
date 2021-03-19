using System;

namespace ChallengeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets make a leap year calculator!");
            Console.WriteLine("Please enter a year: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Lets find out if {userInput} is a leap year.");

            int userNum = Convert.ToInt32(userInput);

            if (userNum % 4 == 0 && userNum % 100 != 0 || userNum % 4 == 0 && userNum % 100 == 0 && userNum % 400 == 0)
            {
                Console.WriteLine($"{userNum} is a leap year!");
            }
            else
            {
                Console.WriteLine($"{userNum} is not a leap year...");
            }

        }
    }
}
