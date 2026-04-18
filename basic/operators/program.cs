using System;

class Program
{
    static void DemonstrateOperators(int a, int b)
    {
        Console.WriteLine("\n--- Arithmetic Operators ---");
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        Console.WriteLine("\n--- Relational Operators ---");
        Console.WriteLine("a > b : " + (a > b));
        Console.WriteLine("a < b : " + (a < b));
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));

        Console.WriteLine("\n--- Logical Operators ---");
        Console.WriteLine("(a > 0 && b > 0): " + (a > 0 && b > 0));
        Console.WriteLine("(a > 0 || b < 0): " + (a > 0 || b < 0));
        Console.WriteLine("!(a > b): " + !(a > b));
    }

    static void Main()
    {
        Console.WriteLine("===== Operators Demonstration =====");

        Console.Write("Enter value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        DemonstrateOperators(a, b);

        Console.WriteLine("\nProgram Completed.");
    }
}
