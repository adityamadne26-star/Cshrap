using System;

class Program
{
    static (int, string, double) GetStudentData()
    {
        return (101, "Aditya", 85.5);
    }

    static void Main()
    {
        Console.WriteLine("===== Tuple Demo =====");

        var student = GetStudentData();

        Console.WriteLine("ID: " + student.Item1);
        Console.WriteLine("Name: " + student.Item2);
        Console.WriteLine("Marks: " + student.Item3);

        Console.WriteLine("Program Completed.");
    }
}
