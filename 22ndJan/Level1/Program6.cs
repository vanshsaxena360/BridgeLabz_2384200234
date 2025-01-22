using System;

class Program
{
    // The Main method is the entry point where the program starts execution.
    static void Main()
    {
        // Declare and initialize a variable named 'fee' to store the course fee amount (INR 125000).
        double fee = 125000;

        // Declare and initialize a variable named 'discountPercent' to store the discount percentage (10%).
        double discountPercent = 10;

        // Calculate the discount amount by multiplying the fee with the discount percentage
        // and dividing by 100 to get the percentage value.
        double discount = (fee * discountPercent) / 100;

        // Calculate the final fee to be paid by subtracting the discount from the original fee.
        double finalFee = fee - discount;

        // Display the discount amount
        Console.WriteLine("The discount amount is INR "+discount+" and the final discounted fee is INR "+finalFee);
    }
}
