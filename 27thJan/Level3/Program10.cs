using System;

public class CollinearPoints
{
    // Method to check if three points are collinear using slope formula
    public static bool ArePointsCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the slopes between AB, BC, and AC
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        // Points are collinear if the slopes are equal
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    // Method to check if three points are collinear using area of triangle formula
    public static bool ArePointsCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        // Calculate the area of the triangle formed by three points
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        // Points are collinear if the area is 0
        return area == 0;
    }

    public static void Main(string[] args)
    {
        // Sample points
        double x1 = 2, y1 = 4;
        double x2 = 4, y2 = 6;
        double x3 = 6, y3 = 8;

        // Checking collinearity using slope method
        bool areCollinearUsingSlope = ArePointsCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        if (areCollinearUsingSlope)
        {
            Console.WriteLine("The points A(" + x1 + ", " + y1 + "), B(" + x2 + ", " + y2 + "), and C(" + x3 + ", " + y3 + ") are collinear using the slope method.");
        }
        else
        {
            Console.WriteLine("The points A(" + x1 + ", " + y1 + "), B(" + x2 + ", " + y2 + "), and C(" + x3 + ", " + y3 + ") are not collinear using the slope method.");
        }

        // Checking collinearity using area of triangle method
        bool areCollinearUsingArea = ArePointsCollinearUsingArea(x1, y1, x2, y2, x3, y3);
        if (areCollinearUsingArea)
        {
            Console.WriteLine("The points A(" + x1 + ", " + y1 + "), B(" + x2 + ", " + y2 + "), and C(" + x3 + ", " + y3 + ") are collinear using the area of triangle method.");
        }
        else
        {
            Console.WriteLine("The points A(" + x1 + ", " + y1 + "), B(" + x2 + ", " + y2 + "), and C(" + x3 + ", " + y3 + ") are not collinear using the area of triangle method.");
        }
    }
}
