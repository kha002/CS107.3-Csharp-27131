using System;

public class ConvertValues
{
    public int kilometerTOmeter(int km)
    {
        int meter = km * 1000;
        return meter;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var convertValues = new ConvertValues();

        int meter = convertValues.kilometerTOmeter(10);

        Console.WriteLine("The equivalent of 10 kilometer in meter is: " + meter);
    }
}
