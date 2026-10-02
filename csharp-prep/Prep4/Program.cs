using System;
using System.Globalization;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNumber = -1;
        
        while (userNumber != 0)
        {
          Console.Write("Enter number: ");
          string entry = Console.ReadLine();
          userNumber = int.Parse(entry);
          
            if (userNumber != 0)
            {
                numbers.Add(userNumber);   
            }
        
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float avg = ((float)sum) / numbers.Count; 

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        int min = 0;
        foreach (int number in numbers)
        {
            if (number > 0) 
            {
                if (min == 0 || number < min)
                {
                    min = number;
                }
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        
        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}