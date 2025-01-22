using System;

class ChocolateDivision
{
    static void Main()
    {
        // Declare variables to store the number of chocolates and children
        int numberOfChocolates, numberOfChildren;

        // Take user input for the number of chocolates and children
        Console.Write("Enter the total number of chocolates: ");
        numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the total number of children: ");
        numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate how many chocolates each child gets and the remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Output the result
        Console.WriteLine("The number of chocolates each child gets is "+chocolatesPerChild+" and the number of remaining chocolates is "+remainingChocolates);
    }
}
