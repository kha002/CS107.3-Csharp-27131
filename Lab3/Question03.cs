using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Digit Sum Calculator!");

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            int sum = CalculateDigitSum(number);
            Console.WriteLine("Sum of digits: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer number.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    static int CalculateDigitSum(int number)
    {
        int sum = 0;

        // Convert the number to its absolute value to handle negative numbers
        number = Math.Abs(number);

        while (number > 0)
        {
            int digit = number % 10; // Get the last digit
            sum += digit; // Add the digit to the sum
            number /= 10; // Remove the last digit from the number
        }

        return sum;
    }
}
