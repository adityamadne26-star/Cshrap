using System;

class Program
{
    static void PrintPattern(int rows)
    {
        Console.WriteLine("\nStar Pattern:\n");

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Pattern Program =====");

        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        PrintPattern(rows);

        Console.WriteLine("Program Completed.");
    }
}
