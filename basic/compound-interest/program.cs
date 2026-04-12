using System;

class Program
{
    static void Main(string[] args)
    {
        double principal, rate, time, amount, compoundInterest;

        // Taking input
        Console.Write("Enter Principal Amount: ");
        principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        time = double.Parse(Console.ReadLine());

        // Calculating amount
        amount = principal * Math.Pow((1 + rate / 100), time);

        // Calculating compound interest
        compoundInterest = amount - principal;

        // Display result
        Console.WriteLine($"\nTotal Amount = {amount}");
        Console.WriteLine($"Compound Interest = {compoundInterest}");
    }
}
