using System;

class Program
{
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static void Main()
    {
        Console.WriteLine("===== Area of Rectangle =====");

        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = CalculateArea(length, width);

        Console.WriteLine("Area of Rectangle: " + area);
        Console.WriteLine("Program Completed.");
    }
}
