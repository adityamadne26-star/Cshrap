using System;

class Program
{
    static void PrintTable(int num)
    {
        Console.WriteLine("\nMultiplication Table of " + num + ":");

        for (int i = 1; i <= 10; i++)
        {
            int result = num * i;
            Console.WriteLine(num + " x " + i + " = " + result);
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Multiplication Table Program =====");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        PrintTable(number);

        Console.WriteLine("Program Finished.");
    }
}
