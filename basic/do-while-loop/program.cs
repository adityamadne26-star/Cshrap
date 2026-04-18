using System;

class Program
{
    static void PrintNumbers(int n)
    {
        int i = 1;

        Console.WriteLine("\nNumbers using DO-WHILE loop:");

        do
        {
            Console.Write(i + " ");
            i++;
        } while (i <= n);
    }

    static void Main()
    {
        Console.WriteLine("===== DO-WHILE Loop Demo =====");

        Console.Write("Enter limit: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(n);

        Console.WriteLine("\nProgram Completed.");
    }
}
