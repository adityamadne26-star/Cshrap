using System;

class Program
{
    static void PrintNumbers(int n)
    {
        Console.WriteLine("\nNumbers using FOR loop:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }

    static void Main()
    {
        Console.WriteLine("===== FOR Loop Demo =====");

        Console.Write("Enter limit: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(n);

        Console.WriteLine("\nProgram Completed.");
    }
}
