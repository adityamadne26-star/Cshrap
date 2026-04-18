using System;

struct Student
{
    public int id;
    public string name;

    public void Display()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Struct Demo =====");

        Student s1;
        s1.id = 101;
        s1.name = "Aditya";

        s1.Display();

        Console.WriteLine("Program Completed.");
    }
}
