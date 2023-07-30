using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Circle Calculator!");

        Console.Write("Enter the radius of the circle: ");
        string radiusInput = Console.ReadLine();

        if (double.TryParse(radiusInput, out double radius))
        {
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("Area of the circle: " + area.ToString("0.00"));
            Console.WriteLine("Circumference of the circle: " + circumference.ToString("0.00"));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
