using System;

class Program
{
    static void DemonstrateBreakContinue()
    {
        Console.WriteLine("\n--- BREAK Example ---");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                break;

            Console.Write(i + " ");
        }

        Console.WriteLine("\n--- CONTINUE Example ---");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                continue;

            Console.Write(i + " ");
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Break & Continue Demo =====");

        DemonstrateBreakContinue();

        Console.WriteLine("\nProgram Completed.");
    }
}
