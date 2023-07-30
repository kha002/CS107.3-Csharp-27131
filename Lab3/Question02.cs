using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Vowel Counter!");

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);

        Console.WriteLine("Number of vowels: " + vowelCount);

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    static int CountVowels(string text)
    {
        int count = 0;

        foreach (char c in text)
        {
            if (IsVowel(c))
            {
                count++;
            }
        }

        return count;
    }

    static bool IsVowel(char c)
    {
        char lowerC = char.ToLower(c);

        return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
    }
}
