using System;

class Program10
{
    static void Main()
    {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());

        double miles = kilometers * 0.621371;

        Console.WriteLine(kilometers+" kilometers is equal to "+miles+" miles");
    }
}
