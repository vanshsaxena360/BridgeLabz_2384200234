using System;

public class ZaraBonusCalculator
{
    // Method to determine the salary and years of service
    public static double[,] GetEmployeeDetails(int employeeCount)
    {
        Random rand = new Random();
        double[,] employeeDetails = new double[employeeCount, 2]; // Column 0: Salary, Column 1: Years of Service

        for (int i = 0; i < employeeCount; i++)
        {
            employeeDetails[i, 0] = rand.Next(10000, 100000); // Random salary between 10000 and 99999
            employeeDetails[i, 1] = rand.Next(1, 21); // Random years of service between 1 and 20
        }

        return employeeDetails;
    }

    // Method to calculate the new salary and bonus based on the years of service
    public static double[,] CalculateBonusAndNewSalary(double[,] employeeDetails, int employeeCount)
    {
        double[,] updatedDetails = new double[employeeCount, 3]; // Column 0: Old Salary, Column 1: New Salary, Column 2: Bonus

        for (int i = 0; i < employeeCount; i++)
        {
            double oldSalary = employeeDetails[i, 0];
            double yearsOfService = employeeDetails[i, 1];
            double bonus = 0;
            double newSalary = oldSalary;

            // Calculate bonus based on years of service
            if (yearsOfService > 5)
            {
                bonus = oldSalary * 0.05; // 5% bonus for more than 5 years
            }
            else
            {
                bonus = oldSalary * 0.02; // 2% bonus for less than 5 years
            }

            newSalary = oldSalary + bonus;

            updatedDetails[i, 0] = oldSalary;
            updatedDetails[i, 1] = newSalary;
            updatedDetails[i, 2] = bonus;
        }

        return updatedDetails;
    }

    // Method to calculate the sum of old salaries, new salaries, and total bonus
    public static void CalculateTotalSalariesAndBonus(double[,] updatedDetails, int employeeCount)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        Console.WriteLine("Employee No.\tOld Salary\tNew Salary\tBonus");

        for (int i = 0; i < employeeCount; i++)
        {
            double oldSalary = updatedDetails[i, 0];
            double newSalary = updatedDetails[i, 1];
            double bonus = updatedDetails[i, 2];

            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            // Display the details for each employee
            Console.WriteLine((i + 1) + "\t\t" + oldSalary + "\t\t" + newSalary + "\t\t" + bonus);
        }

        // Display the total amounts
        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
        Console.WriteLine("Total Bonus Amount: " + totalBonus);
    }

    public static void Main()
    {
        int employeeCount = 10; // Number of employees
        double[,] employeeDetails = GetEmployeeDetails(employeeCount); 
        double[,] updatedDetails = CalculateBonusAndNewSalary(employeeDetails, employeeCount); 
        // Calculate and display totals
		CalculateTotalSalariesAndBonus(updatedDetails, employeeCount); 
    }
}
