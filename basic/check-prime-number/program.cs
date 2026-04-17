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

    static void Main()
    {
        Console.WriteLine("===== Prime Number Check =====");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
            Console.WriteLine("Result: Prime Number");
        else
            Console.WriteLine("Result: Not a Prime Number");

        Console.WriteLine("Program Finished.");
    }
}
