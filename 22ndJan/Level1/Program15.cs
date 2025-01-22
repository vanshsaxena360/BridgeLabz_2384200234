using System;

class TotalPriceCalculator
{
    static void Main()
    {
        // Prompt the user to enter the unit price of the item.
        Console.Write("Enter the unit price of the item in INR: ");
        // Read the user input and convert it to a floating-point number.
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter the quantity of the item.
        Console.Write("Enter the quantity of the item: ");
        // Read the user input and convert it to an integer.
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price by multiplying the unit price by the quantity.
        double totalPrice = unitPrice * quantity;

        // Display the result in a user-friendly format.
        Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity is "+quantity+" and unit price is INR "+unitPrice);
    }
}
