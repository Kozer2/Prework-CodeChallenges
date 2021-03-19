using System;

namespace ChallengeFour
{
    class Program
    {
        static void Main(string[] args)
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
