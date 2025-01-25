using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the salary and years of service
        Console.Write("Enter the employee's salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter the years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Check if the employee qualifies for a bonus
        if (yearsOfService > 5)
        {
            // Calculate 5% bonus
            double bonus = salary * 0.05;
            Console.WriteLine("The bonus amount is: "+bonus);
        }
        else
        {
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}
