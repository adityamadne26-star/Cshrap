using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static void PrintPrimes(int start, int end)
    {
        Console.WriteLine("\nPrime Numbers:");

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Prime Numbers in Range =====");

        Console.Write("Enter starting number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter ending number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        PrintPrimes(start, end);

        Console.WriteLine("\nProgram Finished.");
    }
}
