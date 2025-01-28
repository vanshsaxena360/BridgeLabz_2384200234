using System;

class Program
{
    // Method to calculate various trigonometric functions (sine, cosine, tangent)
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double radians = Math.PI * angle / 180;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the values as an array
        return new double[] {sine, cosine, tangent};
    }

    static void Main(string[] args)
    {
        // Input: Take the angle in degrees from the user
        Console.Write("Enter the angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Call the method to calculate trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angle);

        // Output the results
        Console.WriteLine("Sine of "+angle+"° is: "+results[0].ToString("F4"));
        Console.WriteLine("Cosine of "+angle+"° is: "+results[1].ToString("F4"));
        Console.WriteLine("Tangent of "+angle+"° is: "+results[2].ToString("F4"));
    }
}
