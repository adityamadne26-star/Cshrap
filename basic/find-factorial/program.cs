using System;

class Program
{
    static void Main()
    {
        int num;
        long factorial = 1;

        Console.WriteLine("---- Factorial Program ----");

        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial of " + num + " = " + factorial);
        }
    }
}
