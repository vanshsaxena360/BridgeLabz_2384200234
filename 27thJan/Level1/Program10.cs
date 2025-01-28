using System;

class Program
{
    // Method to find the number of chocolates each child gets and the remainder
    public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        // Calculate the number of chocolates each child gets
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        
        // Calculate the remaining chocolates
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Return both chocolates per child and remaining chocolates as an array
        return new int[] { chocolatesPerChild, remainingChocolates };
    }

    static void Main(string[] args)
    {
        // Input: Take number of chocolates and number of children from the user
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Call the method to find chocolates per child and remaining chocolates
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // Output the result
        Console.WriteLine("Each child gets "+result[0]+" chocolates.");
        Console.WriteLine("Remaining chocolates: "+result[1]);
    }
}
