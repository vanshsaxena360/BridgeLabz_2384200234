using System;

class Program
{
    // Method to find the smallest and largest of the three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = number1;
        int largest = number1;

        // Check for smallest number
        if (number2 < smallest)
            smallest = number2;
        if (number3 < smallest)
            smallest = number3;

        // Check for largest number
        if (number2 > largest)
            largest = number2;
        if (number3 > largest)
            largest = number3;

        // Return both smallest and largest numbers as an array
        return new int[] { smallest, largest };
    }

    static void Main(string[] args)
    {
        // Input: Take three numbers from the user
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Find smallest and largest numbers
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Output the result
        Console.WriteLine("The smallest number is: "+result[0]);
        Console.WriteLine("The largest number is: "+result[1]);
    }
}
