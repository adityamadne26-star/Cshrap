using System;

class Program
{
    static double CalculatePower(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    static void Main()
    {
        Console.WriteLine("===== Power Calculation =====");

        Console.Write("Enter base: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = CalculatePower(baseNum, exponent);

        Console.WriteLine("Result: " + result);

        Console.WriteLine("Program Completed.");
    }
}
