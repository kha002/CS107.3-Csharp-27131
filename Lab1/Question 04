using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Salary Calculator!");

        Console.Write("Enter the salary of the employee: ");
        string salaryInput = Console.ReadLine();

        Console.Write("Enter the tax rate (in decimal form, e.g., 0.15 for 15%): ");
        string taxRateInput = Console.ReadLine();

        if (double.TryParse(salaryInput, out double salary) && double.TryParse(taxRateInput, out double taxRate))
        {
            double taxAmount = salary * taxRate;
            double salaryAfterTax = salary - taxAmount;

            Console.WriteLine("Salary after tax deduction: " + salaryAfterTax.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
