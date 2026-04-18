using System;

class Program
{
    static void GenerateRandomNumbers(int count)
    {
        Random rand = new Random();

        Console.WriteLine("\nRandom Numbers:");

        for (int i = 1; i <= count; i++)
        {
            int num = rand.Next(1, 100);
            Console.Write(num + " ");
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Random Number Generator =====");

        Console.Write("How many numbers to generate? ");
        int count = Convert.ToInt32(Console.ReadLine());

        GenerateRandomNumbers(count);

        Console.WriteLine("\nProgram Completed.");
    }
}
