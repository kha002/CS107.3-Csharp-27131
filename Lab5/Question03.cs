using System;

namespace ArithmeticOperations
{
    class CalculateValues
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            int choice;
            int num1, num2;

            Console.WriteLine("Select the operation you want to perform:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            CalculateValues calculateValues = new CalculateValues();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, calculateValues.Addition(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, calculateValues.Subtraction(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, calculateValues.Multiplication(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("The quotient of {0} and {1} is {2}", num1, num2, calculateValues.Division(num1, num2));
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
