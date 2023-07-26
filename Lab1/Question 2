using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Circle Area Calculator!");

        Console.Write("Enter the radius of the circle: ");
        string radiusInput = Console.ReadLine();
        
        if (double.TryParse(radiusInput, out double radius))
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("The area of the circle is: " + area.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
