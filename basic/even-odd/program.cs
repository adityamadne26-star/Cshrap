using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("====================================");
        Console.WriteLine("   EVEN OR ODD NUMBER CHECKER");
        Console.WriteLine("====================================\n");

        int number = GetValidNumber();

        CheckEvenOdd(number);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to take valid input
    static int GetValidNumber()
    {
        int num;
        bool isValid = false;

        do
        {
            Console.Write("Enter an integer number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out num))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.\n");
            }

        } while (!isValid);

        return num;
    }

    // Function to check even or odd
    static void CheckEvenOdd(int num)
    {
        Console.WriteLine("\nProcessing...\n");

        if (num % 2 == 0)
        {
            Console.WriteLine($"The number {num} is EVEN.");
        }
        else
        {
            Console.WriteLine($"The number {num} is ODD.");
        }
    }
}
