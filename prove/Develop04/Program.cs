using System;

// Exceed: Non repeated questions in the reflection activity until all have been used.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        string selection = "";

        while (selection != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("What would you like to do? ");
            
            selection = Console.ReadLine();

            if (selection == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (selection == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (selection == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (selection == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program!");
            }
            else
            {
                Console.WriteLine("Invalid selection.  Please choose 1,2,3 or 4.");
            }
        }
    }
}