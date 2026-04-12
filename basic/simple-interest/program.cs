using System;

class Program
{
    static void Main(string[] args)
    {
        double principal, rate, time, simpleInterest;

        // Taking input
        Console.Write("Enter Principal Amount: ");
        principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        time = double.Parse(Console.ReadLine());

        // Calculating Simple Interest
        simpleInterest = (principal * rate * time) / 100;

        // Display result
        Console.WriteLine($"\nSimple Interest = {simpleInterest}");
    }
}
