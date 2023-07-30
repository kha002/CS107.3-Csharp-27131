using System;

public class FindValues
{
    public double findArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return area;
    }

    public double findCircumference(double radius)
    {
        double circumference = 2 * Math.PI * radius;
        return circumference;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var findValues = new FindValues();


        Console.WriteLine("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        double area = findValues.findArea(radius);
        double circumference = findValues.findCircumference(radius);

        Console.WriteLine("The area of the circle is: " + area);
        Console.WriteLine("The circumference of the circle is: " + circumference);
    }
}
