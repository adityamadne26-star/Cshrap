using System;

class Program
{
    static double CalculateSalary(double basic)
    {
        double hra = basic * 0.20;
        double da = basic * 0.10;
        double total = basic + hra + da;

        Console.WriteLine("HRA: " + hra);
        Console.WriteLine("DA: " + da);

        return total;
    }

    static void Main()
    {
        Console.WriteLine("===== Salary Calculation =====");

        Console.Write("Enter basic salary: ");
        double basic = Convert.ToDouble(Console.ReadLine());

        double totalSalary = CalculateSalary(basic);

        Console.WriteLine("Total Salary: " + totalSalary);

        Console.WriteLine("Program Completed.");
    }
}
