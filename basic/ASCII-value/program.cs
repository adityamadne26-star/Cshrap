using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ASCII Value Program =====");

        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        int asciiValue = (int)ch;

        Console.WriteLine("Character: " + ch);
        Console.WriteLine("ASCII Value: " + asciiValue);

        Console.WriteLine("Program Completed.");
    }
}
