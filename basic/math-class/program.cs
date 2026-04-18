using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Math Class Demo =====");

        double num = 25.7;

        Console.WriteLine("Square Root: " + Math.Sqrt(num));
        Console.WriteLine("Power (2^3): " + Math.Pow(2, 3));
        Console.WriteLine("Absolute: " + Math.Abs(-10));
        Console.WriteLine("Ceiling: " + Math.Ceiling(num));
        Console.WriteLine("Floor: " + Math.Floor(num));
        Console.WriteLine("Round: " + Math.Round(num));

        Console.WriteLine("Program Completed.");
    }
}
