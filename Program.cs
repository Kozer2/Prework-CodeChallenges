using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengeOne();
            ChallengeTwo();
            ChallengeThree();
            ChallengeFour();
        }




        static void ChallengeOne()
        {
            Console.WriteLine("Hello! Please enter 5 numbers between 1 and 10");
            string[] numArr = new string[5];

            for (int i = 0; i < numArr.Length; i++)
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
            Console.WriteLine(string.Join(" ", numArr));
            Console.WriteLine("Enter a number you entered into the list to determine your score: ");
            string scoreNum = Console.ReadLine();
            int counter = 0;

            foreach (string num in numArr)
            {
                if (scoreNum == num)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Your score number you entered is: {scoreNum}");
            int finalScore = Convert.ToInt32(scoreNum);
            finalScore = finalScore * counter;
            Console.WriteLine($"Your final score is: {finalScore}");
        } // end challengeOne


        static void ChallengeTwo()
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

        } // end Challenge two



        static void ChallengeThree()
        {
            Console.WriteLine("Please enter an array of 3 numbers: ");
            int[] numArr = new int[3];

            for (int i = 0; i < numArr.Length; i++)
            {
                string testNum = Console.ReadLine();
                int numNum = Convert.ToInt32(testNum);
                numArr[i] = numNum;
                Console.WriteLine($"You entered: {numArr[i]}");
            }
            Console.WriteLine("Your array of Numbers is: ");
            Console.WriteLine(String.Join(',', numArr));
            Console.WriteLine("Using complicated math we will now find out if they are a pefect sequence of numbers! ");

            int total = 0;
            int results = 1;

            foreach (var num in numArr)
            {
                total += num;
                results *= num;
            }
            if (total == results)
            {
                Console.WriteLine(String.Join(',', numArr) + " Its a perfect sequence!");
            }
            else
            {
                Console.WriteLine(String.Join(',', numArr) + " is not perfect...");
            }
        } // end challenge three


        static void ChallengeFour()
        {
            Console.WriteLine("Hello! Please enter a length and width for the array we will work with.");
            string length = Console.ReadLine();
            string width = Console.ReadLine();
            int length2 = Convert.ToInt32(length);
            int width2 = Convert.ToInt32(width);
            Console.WriteLine($"Our array with have a length of {length} and a width of {width}.");

            int[,] myArray = new int[width2, length2];

            //use random generator to fill arrays. 
        }



    }
}
