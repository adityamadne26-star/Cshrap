using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Nullable Types Demo =====");

        int? number = null;

        if (number.HasValue)
            Console.WriteLine("Value: " + number.Value);
        else
            Console.WriteLine("Value is NULL");

        // Assign value
        number = 50;

        Console.WriteLine("After assigning value: " + number);

        Console.WriteLine("Program Completed.");
    }
}
