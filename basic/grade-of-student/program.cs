using System;

class Program
{
    static char CalculateGrade(double percentage)
    {
        if (percentage >= 90) return 'A';
        else if (percentage >= 75) return 'B';
        else if (percentage >= 60) return 'C';
        else if (percentage >= 50) return 'D';
        else return 'F';
    }

    static void Main()
    {
        Console.WriteLine("===== Grade Calculation =====");

        Console.Write("Enter marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        char grade = CalculateGrade(marks);

        Console.WriteLine("Grade: " + grade);

        Console.WriteLine("Program Completed.");
    }
}
