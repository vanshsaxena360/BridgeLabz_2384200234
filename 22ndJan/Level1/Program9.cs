using System;

class DiscountCalculator
{
    static void Main()
    {
        // Prompt the user to enter the student fee.
        Console.Write("Enter the student fee (in INR): ");
        // Read user input for the fee and convert it to a double.
        double fee = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the discount percentage offered by the university.
        Console.Write("Enter the discount percentage: ");
        // Read user input for the discount percentage and convert it to a double.
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate the discount amount using the formula: (fee * discountPercent) / 100.
        double discount = (fee * discountPercent) / 100;

        // Calculate the final fee by subtracting the discount from the original fee.
        double finalFee = fee - discount;

        // Display the discount amount and final discounted fee.
        Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+finalFee);
    }
}
