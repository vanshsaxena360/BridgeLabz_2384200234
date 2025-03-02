using System;

class Program
{
    static void Main()
    {
        try
        {
            // Taking user input for array size
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            // Taking user input for array elements
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element at index "+i+": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Taking user input for index and divisor
            Console.Write("Enter the index to access: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            try
            {
                // Attempting to access an array element
                int value = numbers[index];
                try
                {
                    // Attempting to divide the element by the divisor
                    int result = value / divisor;
                    Console.WriteLine("Division Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    // Handling division by zero
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                // Handling invalid array index
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            // Handling non-numeric input
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (Exception ex)
        {
            // Handling unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
