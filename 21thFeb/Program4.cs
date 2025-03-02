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
                Console.Write($"Enter element at index {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            // Taking user input for index to retrieve
            Console.Write("Enter the index to retrieve: ");
            int index = int.Parse(Console.ReadLine());
            
            // Retrieving and printing the value at the given index
            Console.WriteLine("Value at index "+index+": "+numbers[index]);
        }
        catch (IndexOutOfRangeException)
        {
            // Handling exception if the index is out of range
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            // Handling exception if the array is null
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            // Handling exception if user enters a non-numeric value
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
        catch (Exception ex)
        {
            // Handling any other unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
