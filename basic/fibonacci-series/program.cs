using System;

class Program
{
    static void Main()
    {
        int numberOfTerms;
        int firstTerm = 0, secondTerm = 1;

        Console.WriteLine("=== Fibonacci Series Program ===");
        Console.Write("Enter number of terms: ");
        numberOfTerms = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nFibonacci Series:");

        for (int i = 1; i <= numberOfTerms; i++)
        {
            Console.Write(firstTerm + " ");

            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }

        Console.WriteLine("\nProgram Completed.");
    }
}
