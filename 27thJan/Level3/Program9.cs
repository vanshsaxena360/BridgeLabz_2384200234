using System;

public class Geometry
{
    // Method to calculate Euclidean distance between two points
    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        // Euclidean distance formula
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    // Method to find the equation of the line given two points
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        // Calculate slope m
        double m = (y2 - y1) / (x2 - x1);
        
        // Calculate y-intercept b
        double b = y1 - m * x1;

        // Return an array containing the slope (m) and y-intercept (b)
        return new double[] { m, b };
    }

    public static void Main(string[] args)
    {
        // Take inputs for the two points (x1, y1) and (x2, y2)
        Console.Write("Enter the x1 coordinate: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the y1 coordinate: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the x2 coordinate: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the y2 coordinate: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        // Calculate and display the Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("The Euclidean distance between the points (" + x1 + ", " + y1 + ") and (" + x2 + ", " + y2 + ") is: " + distance);

        // Calculate and display the equation of the line
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine("The equation of the line passing through the points (" + x1 + ", " + y1 + ") and (" + x2 + ", " + y2 + ") is:");
        Console.WriteLine("y = " + lineEquation[0] + " * x + " + lineEquation[1]);
    }
}
