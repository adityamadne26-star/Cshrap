using System;

class Program
{
    static int CountDigits(int num)
    {
        int count = 0;

        while (num > 0)
        {
            count++;
            num = num / 10;
        }

        return count;
    }

    static void Main()
    {
        Console.WriteLine("===== Count Digits Program =====");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int totalDigits = CountDigits(number);

        Console.WriteLine("Number Entered: " + number);
        Console.WriteLine("Total Digits: " + totalDigits);

        Console.WriteLine("Program Finished.");
    }
}
