using System;
using System.Diagnostics;
// To exceed I added more scriptures to the bank and randomized them on start up.
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        ));

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ));

        scriptures.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        ));

        scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."
        ));

        Random random = new Random();
        int index = random.Next(scriptures.Count);

        Scripture scripture = scriptures[index];

        string userInput = "";

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to hid words or type 'quit' to exit");

            userInput = Console.ReadLine();
            if (userInput != null && userInput.Trim().ToLower() == "quit")
            {
                break;

            }
            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Thanks for practicing!");
    }
}