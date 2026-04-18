using System;

class Program
{
    static bool IsLeapYear(int year)
    {
        // Leap year logic
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            return true;
        else
            return false;
    }

    static void Main()
    {
        Console.WriteLine("===== Leap Year Check =====");

        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsLeapYear(year))
            Console.WriteLine("Result: It is a Leap Year.");
        else
            Console.WriteLine("Result: It is NOT a Leap Year.");

        Console.WriteLine("Program Completed.");
    }
}
