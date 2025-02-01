using System;

public class PrimeChecker
{
    // Function to check if a number is prime
    public static bool IsPrime(int number)
    {
        // If the number is less than 2, it is not prime
        if (number < 2){
            return false;
        }

        // Check divisibility from 2 to the square root of the number
        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0){
                return false; // If divisible, it's not prime
            }
        }
        return true; // If not divisible by any number, it's prime
    }

    public static void Main()
    {
        // Input from the user
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Check if the number is prime using the IsPrime method
        if (IsPrime(num)){
            Console.WriteLine($"{num} is a prime number.");
        }
        else{
            Console.WriteLine($"{num} is not a prime number.");
        }
    }
}
