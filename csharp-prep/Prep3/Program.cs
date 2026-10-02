using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            Console.WriteLine("New magic number locked in and ready!");
            int magicNumber = randomGenerator.Next(1,11);
            int guess = 0;
            int guessCount = 0;
            while (magicNumber != guess)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess); 
                guessCount++;
                
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    Console.Write("Would you like to play again? ");
                    response = Console.ReadLine().ToLower();
                }

            }
        }
    }
}