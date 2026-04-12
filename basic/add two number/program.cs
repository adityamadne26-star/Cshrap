using System;

class Program
{
    static void Main(string[] args)
    {
        // Taking first number
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        // Taking second number
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Adding numbers
        int sum = num1 + num2;

        // Display result
        Console.WriteLine("\nSum = " + sum);
    }
}
