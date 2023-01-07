using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGeneration = new Random();
        int number = randomGeneration.Next(1, 101);
        int guess = 1000;
        while (guess != number)
        {
            Console.WriteLine("What is the magic number? ");
            string sGuess = Console.ReadLine();
            guess = int.Parse(sGuess);
            if (guess != number)
            {
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("Higher");
                }
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }


    }
}