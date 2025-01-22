using System;

class Program
{
    static void Main()
    {
        // Declare and initialize the cost price and selling price as variables.
        // The cost price (CP) is given as INR 129, and the selling price (SP) is given as INR 191.
        double costPrice = 129;
        double sellingPrice = 191;

        // Calculate the profit using the formula: Profit = Selling Price - Cost Price.
        double profit = sellingPrice - costPrice;

        // Calculate the profit percentage using the formula: Profit Percentage = (Profit / Cost Price) * 100.
        double profitPercentage = (profit / costPrice) * 100;

        // Display the results
        Console.WriteLine("The Cost Price is INR "+costPrice+" and Selling Price is INR "+sellingPrice+ "\nThe Profit is INR "+profit+" and the Profit Percentage is "+profitPercentage);
    }
}
