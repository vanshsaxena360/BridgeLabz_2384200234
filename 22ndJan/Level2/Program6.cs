using System;

class TotalIncome
{
    static void Main()
    {
        // Declare variables to store the salary and bonus
        double salary, bonus;

        // Prompt the user to enter the salary
        Console.Write("Enter the salary: ");
        salary = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the bonus
        Console.Write("Enter the bonus: ");
        bonus = Convert.ToDouble(Console.ReadLine());

        // Compute the total income by adding salary and bonus
        double totalIncome = salary + bonus;

        // Output the result
        Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+". Hence Total Income is INR "+totalIncome);
    }
}
