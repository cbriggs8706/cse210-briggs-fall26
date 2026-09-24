using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);

        if (x >= 90)
        {
            Console.WriteLine("Your letter grade is an A.");
        }
        else if (x >= 80)
        {
            Console.WriteLine("Your letter grade is a B.");
        }
        else if (x >= 70)
        {
            Console.WriteLine("Your letter grade is a C.");
        }
        else if (x >= 60)
        {
            Console.WriteLine("Your letter grade is a D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is an F.");
        }

// Note to self: Next time simplify and try to not have so much redundancy.  The example shows the refactoring. 

        if (x >= 70)
        {
            Console.WriteLine ("Congratulations! You've passed the class!");
        }
        else
        {
            Console.WriteLine ("You did not pass the class. But don't cry, you'll get it next time champ!");
        }
    }
}