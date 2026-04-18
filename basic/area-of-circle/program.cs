using System;

class Program
{
    static double CalculateArea(double radius)
    {
        const double PI = 3.14159;
        return PI * radius * radius;
    }

    static void Main()
    {
        Console.WriteLine("===== Area of Circle =====");

        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(radius);

        Console.WriteLine("Area of Circle: " + area);
        Console.WriteLine("Program Completed.");
    }
}
