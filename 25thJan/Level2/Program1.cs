using System;

public class ZaraBonus
{
    public static void Main(string[] args)
    {
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];

        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;

        for (int i = 0; i < 10; i++)
        {
			// taking salaries input
            Console.WriteLine("Enter salary for employee " + (i + 1) + ":");
            salaries[i] = double.Parse(Console.ReadLine());  
            
			// taking years of service input
            Console.WriteLine("Enter years of service for employee " + (i + 1) + ":");
            yearsOfService[i] = double.Parse(Console.ReadLine());  

            totalOldSalary += salaries[i];
        }

        for (int i = 0; i < 10; i++)
        {
			// for 5% bonus
            if (yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05; 
            }
            else
            {
				// for 2% bonus
                bonuses[i] = salaries[i] * 0.02;
            }

            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalNewSalary += newSalaries[i];
        }

        Console.WriteLine("\nTotal Bonus Payout: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);

        // Display employee-wise details (optional)
        Console.WriteLine("\nEmployee Details:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": Old Salary = " + salaries[i] + ", Bonus = " + bonuses[i] + ", New Salary = " + newSalaries[i]);
        }
    }
}