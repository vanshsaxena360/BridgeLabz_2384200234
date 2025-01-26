using System;

public class LargestDigits
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigits = 10; // Initial size of the array
        int[] digits = new int[maxDigits];
        int index = 0;

        while (number != 0)
        {
            if (index >= maxDigits)
            {
                // Increase array size by 10
                maxDigits += 10;
                int[] temp = new int[maxDigits];
                Array.Copy(digits, temp, index); 
                digits = temp; 
            }

            digits[index] = number % 10;
            number /= 10;
            index++;
        }

        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}