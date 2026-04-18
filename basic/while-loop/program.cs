using System;

class Program
{
    static void PrintNumbers(int n)
    {
        int i = 1;

        Console.WriteLine("\nNumbers using WHILE loop:");

        while (i <= n)
        {
            Console.Write(i + " ");
            i++;
        }
    }

    static void Main()
    {
        Console.WriteLine("===== WHILE Loop Demo =====");

        Console.Write("Enter limit: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(n);

        Console.WriteLine("\nProgram Completed.");
    }
}
