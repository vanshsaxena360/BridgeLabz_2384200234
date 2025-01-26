using System;

class Program{
	static void Main(string[] args){
		double[] numbers = new double[10]; // Array to store numbers
        double total = 0.0; // Variable to store the sum
        int index = 0; // Index for the array

        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num <= 0)
            {
                break; // Stop if 0 or negative number is entered
            }

            if (index >= 10)
            {
                Console.WriteLine("Array is full.");
                break; // Stop if array is full
            }

            numbers[index] = num;
            index++;
        }

        Console.WriteLine("Entered numbers:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(numbers[i] + " ");
            total += numbers[i];
        }
        Console.WriteLine();

        Console.WriteLine("Sum of all numbers: " + total);
	}
}