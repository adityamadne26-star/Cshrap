using System;

class Program
{
    static void ShowDateTimeDetails()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("\nCurrent Date & Time: " + now);
        Console.WriteLine("Date: " + now.Date);
        Console.WriteLine("Time: " + now.TimeOfDay);

        Console.WriteLine("Day: " + now.Day);
        Console.WriteLine("Month: " + now.Month);
        Console.WriteLine("Year: " + now.Year);

        Console.WriteLine("Day of Week: " + now.DayOfWeek);
        Console.WriteLine("Day of Year: " + now.DayOfYear);

        Console.WriteLine("\nCustom Format: " + now.ToString("dd-MM-yyyy HH:mm:ss"));
    }

    static void Main()
    {
        Console.WriteLine("===== DateTime Class Demo =====");

        ShowDateTimeDetails();

        Console.WriteLine("\nProgram Completed.");
    }
}
