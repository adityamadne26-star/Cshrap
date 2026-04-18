using System;

class Program
{
    static void CheckNumber(int num)
    {
        if (num > 0)
        {
            Console.WriteLine("Number is Positive");
        }
        else if (num < 0)
        {
            Console.WriteLine("Number is Negative");
        }
        else
        {
            Console.WriteLine("Number is Zero");
        }
    }

    static void Main()
    {
        Console.WriteLine("===== Conditional Statement Demo =====");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        CheckNumber(number);

        Console.WriteLine("Program Completed.");
    }
}
