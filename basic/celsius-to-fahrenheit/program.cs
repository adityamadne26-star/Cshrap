using System;

class Program
{
    static double ConvertToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main()
    {
        Console.WriteLine("===== Temperature Conversion =====");

        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = ConvertToFahrenheit(celsius);

        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

        Console.WriteLine("Program Finished.");
    }
}
