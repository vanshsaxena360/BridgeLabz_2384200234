using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        // Declare variables to store the Principal, Rate, and Time
        double principal, rate, time;

        // Take user input for the Principal, Rate, and Time
        Console.Write("Enter the Principal amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of Interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time period in years: ");
        time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest using the formula
        double simpleInterest = (principal * rate * time) / 100;

        // Output the result
        Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time+" years.");
    }
}
