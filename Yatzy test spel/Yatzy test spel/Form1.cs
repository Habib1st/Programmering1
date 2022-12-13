using System;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dice = new int[5];
            Random random = new Random();

            // Roll the dice
            for (int i = 0; i < 5; i++)
            {
                dice[i] = random.Next(1, 7);
            }

            // Print the results
            Console.WriteLine("You rolled: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(dice[i] + " ");
            }
            Console.WriteLine();

            // Calculate the score
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                score += dice[i];
            }
            Console.WriteLine("Your score is: " + score);
        }
    }
}