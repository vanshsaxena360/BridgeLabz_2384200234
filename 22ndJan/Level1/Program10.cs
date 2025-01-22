using System;

class HeightConverter
{
    static void Main()
    {
        // Prompt the user to enter their height in centimeters.
        Console.Write("Enter your height in centimeters: ");

        // Read the user input and convert it to a double to allow for decimal values.
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // Conversion constants.
        const double CM_TO_INCH = 2.54; // 1 inch = 2.54 cm
        const int INCHES_IN_FOOT = 12; // 1 foot = 12 inches

        // Convert height from centimeters to total inches.
        double totalInches = heightInCm / CM_TO_INCH;

        // Calculate the height in feet by dividing total inches by 12 and taking the integer part.
        int feet = (int)(totalInches / INCHES_IN_FOOT);

        // Calculate the remaining inches after converting to feet.
        double inches = totalInches % INCHES_IN_FOOT;

        // Display the result.
        Console.WriteLine("Your height in cm is "+heightInCm+", while in feet is "+feet+" and inches is "+inches);
    }
}
