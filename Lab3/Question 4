using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Odd Number Sum Calculator!");

        Console.Write("Enter a positive integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n) && n > 0)
        {
            int sum = CalculateOddNumberSum(n);
            Console.WriteLine("Sum of odd numbers: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    static int CalculateOddNumberSum(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i += 2)
        {
            sum += i;
        }

        return sum;
    }
}
