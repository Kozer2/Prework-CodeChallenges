using System;

namespace ChallengeThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of 3 numbers: ");
            int[] numArr = new int[3];

            for(int i = 0; i < numArr.Length; i++)
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
            
            foreach(var num in numArr)
            {
                total += num;
                results *= num;
            }
            if(total == results)
            {
                Console.WriteLine(String.Join(',', numArr) + " Its a perfect sequence!");
            }
            else
            {
                Console.WriteLine(String.Join(',', numArr) + " is not perfect...");
            }
        }
    }
}
