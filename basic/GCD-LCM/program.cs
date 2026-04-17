using System;

class Program
{
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }

    static void Main()
    {
        Console.WriteLine("===== GCD and LCM Program =====");

        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = CalculateGCD(num1, num2);
        int lcm = CalculateLCM(num1, num2, gcd);

        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);

        Console.WriteLine("Program Finished.");
    }
}
