using System;

class Program
{
    static void Main()
    {
        int number, reversedNumber = 0;

        Console.WriteLine("=== Palindrome Number Program ===");
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }

        Console.WriteLine("Original Number: " + originalNumber);
        Console.WriteLine("Reversed Number: " + reversedNumber);

        if (originalNumber == reversedNumber)
            Console.WriteLine("Result: It is a Palindrome Number.");
        else
            Console.WriteLine("Result: It is NOT a Palindrome Number.");

        Console.WriteLine("Program Completed.");
    }
}
