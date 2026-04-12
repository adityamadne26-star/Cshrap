  using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, temp;

        // Taking input
        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        // Swapping using temp variable
        temp = num1;
        num1 = num2;
        num2 = temp;

        // Display result
        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("First number = " + num1);
        Console.WriteLine("Second number = " + num2);
    }
