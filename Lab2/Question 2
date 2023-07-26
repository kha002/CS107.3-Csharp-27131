using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Arithmetic Calculator!");

        Console.Write("Enter the first number: ");
        string firstNumberInput = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string secondNumberInput = Console.ReadLine();

        if (double.TryParse(firstNumberInput, out double firstNumber) && double.TryParse(secondNumberInput, out double secondNumber))
        {
            double sum = firstNumber + secondNumber;
            double subtraction = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double division = firstNumber / secondNumber;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Subtraction: " + subtraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
