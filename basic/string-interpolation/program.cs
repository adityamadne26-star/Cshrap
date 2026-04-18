using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== String Interpolation =====");

        string name = "Aditya";
        int age = 20;

        string message = $"My name is {name} and I am {age} years old.";

        Console.WriteLine(message);

        Console.WriteLine("Program Completed.");
    }
}
