using System;

class WeightConversion
{
    static void Main()
    {
        // Declare a variable to store the weight in pounds
        double weightInPounds;

        // Take user input for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert weight from pounds to kilograms using the formula
        double weightInKilograms = weightInPounds * 2.2;

        // Output the result
        Console.WriteLine("The weight of the person in pounds is "+weightInPounds+" and in kilograms is "+weightInKilograms);
    }
}
