using System;

class Program
{
    static void ConvertDays(int totalDays)
    {
        int years = totalDays / 365;
        int remainingDays = totalDays % 365;

        int months = remainingDays / 30;
        int days = remainingDays % 30;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Days: " + days);
    }

    static void Main()
    {
        Console.WriteLine("===== Days Conversion Program =====");

        Console.Write("Enter total number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        ConvertDays(days);

        Console.WriteLine("Program Completed.");
    }
}
