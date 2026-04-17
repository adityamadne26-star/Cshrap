using System;

class Program
{
    static int CalculateSum(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += digit;
            num = num / 10;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("===== Sum of Digits Program =====");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CalculateSum(number);

        Console.WriteLine("Number Entered: " + number);
        Console.WriteLine("Sum of Digits: " + result);

        Console.WriteLine("Program Finished.");
    }
}
