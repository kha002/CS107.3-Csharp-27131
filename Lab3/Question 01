using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Even-Odd Number Checker!");

        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
