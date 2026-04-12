using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("   POSITIVE / NEGATIVE NUMBER CHECKER");
        Console.WriteLine("======================================\n");

        int number = ReadValidNumber();

        AnalyzeNumber(number);

        Console.WriteLine("\nProgram finished. Press any key to exit...");
        Console.ReadKey();
    }

    // Method to read valid integer input
    static int ReadValidNumber()
    {
        int num;
        bool validInput = false;

        do
        {
            Console.Write("Enter an integer number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out num))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("❌ Invalid input! Please enter a valid integer.\n");
            }

        } while (!validInput);

        return num;
    }

    // Method to check number type
    static void AnalyzeNumber(int num)
    {
        Console.WriteLine("\nAnalyzing number...\n");

        if (num > 0)
        {
            Console.WriteLine($"The number {num} is POSITIVE.");
        }
        else if (num < 0)
        {
            Console.WriteLine($"The number {num} is NEGATIVE.");
        }
        else
        {
            Console.WriteLine("The number is ZERO.");
        }
    }
}
