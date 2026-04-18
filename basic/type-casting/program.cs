using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Type Casting Demo =====");

        // Implicit Casting
        int num = 10;
        double d = num;
        Console.WriteLine("Implicit Casting (int → double): " + d);

        // Explicit Casting
        double value = 12.56;
        int result = (int)value;
        Console.WriteLine("Explicit Casting (double → int): " + result);

        Console.WriteLine("Program Completed.");
    }
}
