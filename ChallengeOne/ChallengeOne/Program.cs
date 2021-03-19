using System;

namespace ChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter 5 numbers between 1 and 10");
            string[] numArr = new string[5];

            for(int i = 0; i < numArr.Length; i++)
            {
                string userInput = Console.ReadLine();
                int testNum = Convert.ToInt32(userInput);
                if (testNum > 10)
                {
                    Console.WriteLine("The number you entered is greater than 10, please enter a number between 1 and 10.");
                    i--;
                } // end if
                else
                {
                    numArr[i] = userInput;
                    Console.WriteLine($"You entered: {numArr[i]}");
                } // end else
                
            } // end for loop
            Console.WriteLine("You entered the following numbers: ");
            Console.WriteLine(string.Join(" ",  numArr));
            Console.WriteLine("Enter a number you entered into the list to determine your score: ");
            string scoreNum = Console.ReadLine();
            int counter = 0;

            foreach(string num in numArr)
            {
                if(scoreNum == num)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Your score number you entered is: {scoreNum}");
            int finalScore = Convert.ToInt32(scoreNum);
            finalScore = finalScore * counter;
            Console.WriteLine($"Your final score is: {finalScore}");
        }
    }
}
