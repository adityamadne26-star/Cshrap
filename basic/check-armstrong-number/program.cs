using System;

class Program
{
    static void Main()
    {
        int number, sum = 0;

        Console.WriteLine("=== Armstrong Number Program ===");
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int digitCount = number.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, digitCount);
            number = number / 10;
        }

        Console.WriteLine("Original Number: " + originalNumber);
        Console.WriteLine("Calculated Sum: " + sum);

        if (sum == originalNumber)
            Console.WriteLine("Result: It is an Armstrong Number.");
        else
            Console.WriteLine("Result: It is NOT an Armstrong Number.");

        Console.WriteLine("Program Completed.");
    }
}
