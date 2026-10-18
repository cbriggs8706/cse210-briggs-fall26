using System;

// To exceed requirements I have added the ability to choose a different prompt as well as an unsaved entries reminder prompt before quitting
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        
        PromptGenerator promptGenerator = new PromptGenerator();
        
        Journal journal = new Journal();

        int choice = 0;
        
        bool unsavedChanges = false;

        while (choice !=5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choiceResponse = Console.ReadLine();
            choice = int.Parse(choiceResponse);
            if (choice == 1)
            {
                // Write
                string prompt = promptGenerator.GetRandomPrompt();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine(prompt);
                Console.WriteLine("Would you like a different prompt? (y/n)");
                string anotherPrompt = Console.ReadLine().ToLower();
                while (anotherPrompt == "y")
                {
                    string previousPrompt = prompt;
                    prompt = promptGenerator.GetRandomPrompt();
                    while (prompt == previousPrompt)
                    {
                        prompt = promptGenerator.GetRandomPrompt();
                    }
                    Console.WriteLine(prompt);
                    Console.WriteLine("Would you like a different prompt? (y/n)");
                    anotherPrompt = Console.ReadLine().ToLower();
                }
                Console.WriteLine("Your response: ");
                Console.Write("> ");
                string response = Console.ReadLine();
                Entry entry = new Entry(dateText, prompt, response);
                journal._entries.Add(entry);
                unsavedChanges = true;
            }
            else if (choice == 2)
            {
                // Display
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                // Load file
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                unsavedChanges = false;

            }
            else if (choice == 4)
            {
                // Save file
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                unsavedChanges = false;
            }
            else if (choice == 5)
            {
                // Quit
                if (unsavedChanges)
                {
                    Console.Write("You have unsaved entries. Would you like to save? (y/n)");
                    string saveChanges = Console.ReadLine().ToLower();
                    if (saveChanges == "y")
                    {
                        Console.Write("What is the filename? ");
                        string filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                        unsavedChanges = false;
                    }
                }
            }
              
        }

        
    }
}