class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Summation Calculator!");

        Console.Write("Enter the first number: ");
        string firstNumberInput = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string secondNumberInput = Console.ReadLine();

        if (double.TryParse(firstNumberInput, out double firstNumber) && double.TryParse(secondNumberInput, out double secondNumber))
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine("The summation of the numbers is: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
