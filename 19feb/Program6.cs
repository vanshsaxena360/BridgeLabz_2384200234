using System;

class Program6
{
    static void Main()
    {
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Rate of interest (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;

        Console.WriteLine("The Simple Interest is" +simpleInterest);
    }
}
