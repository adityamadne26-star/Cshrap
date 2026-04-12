using System;

class Program
{
    static void Main(string[] args)
    {
        // Taking input
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Finding maximum
        if (num1 > num2)
        {
            Console.WriteLine($"\nMaximum number is: {num1}");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"\nMaximum number is: {num2}");
        }
        else
        {
            Console.WriteLine("\nBoth numbers are equal");
        }
    }
}
