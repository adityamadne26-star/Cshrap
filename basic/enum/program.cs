using System;

enum Days
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Enum Demo =====");

        Days today = Days.Wednesday;

        Console.WriteLine("Today is: " + today);
        Console.WriteLine("Numeric value: " + (int)today);

        Console.WriteLine("Program Completed.");
    }
}
