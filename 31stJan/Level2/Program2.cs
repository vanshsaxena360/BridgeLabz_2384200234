using System;

class MaximumOfThree
{
    // Method to take integer input from the user
    static int GetNumberInput(string prompt)
    {
        Console.Write(prompt);
        int number=int.Parse(Console.ReadLine());
 
        return number;
    }

    // Method to find the maximum of three numbers
    static int FindMaximum(int num1, int num2, int num3)
    {
        int max = num1;

        if (num2 > max)
            max = num2;
        
        if (num3 > max)
            max = num3;
        
        return max;
    }
	static void Main()
    {
        int num1 = GetNumberInput("Enter the first number: ");
        int num2 = GetNumberInput("Enter the second number: ");
        int num3 = GetNumberInput("Enter the third number: ");
        
        int max = FindMaximum(num1, num2, num3);
        
        Console.WriteLine("The maximum of {0}, {1}, and {2} is: {3}",num1, num2,num3,max);
    }
}
