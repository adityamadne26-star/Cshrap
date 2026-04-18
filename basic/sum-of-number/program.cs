using System;

class Program
{
    static int CalculateSum(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("===== Sum of Natural Numbers =====");

        Console.Write("Enter value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateSum(n);

        Console.WriteLine("Sum: " + result);

        Console.WriteLine("Program Completed.");
    }
}
