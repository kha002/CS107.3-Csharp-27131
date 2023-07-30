using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Even-Odd Number Checker!");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter number #{i}: ");
            string numberInput = Console.ReadLine();

            if (int.TryParse(numberInput, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number.");
            }
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
