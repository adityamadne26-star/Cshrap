using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== var and dynamic Demo =====");

        // var (compile-time type)
        var num = 10;
        var text = "Hello";

        Console.WriteLine("var int: " + num);
        Console.WriteLine("var string: " + text);

        // dynamic (runtime type)
        dynamic value = 100;
        Console.WriteLine("Dynamic int: " + value);

        value = "Now I am string";
        Console.WriteLine("Dynamic string: " + value);

        Console.WriteLine("Program Completed.");
    }
}
