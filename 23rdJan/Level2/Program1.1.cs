using System;

class Program{
	static void Main(string[] args){
		// Prompt the user to enter a number
		Console.Write("Enter a number: ");
		int num = int.Parse(Console.ReadLine());
		
		// prime number should greater than 1
		if(num<1){
			Console.WriteLine("The number is not a prime number");
		}
		else{
			bool isPrime = true; // Assume the number is prime

            // Loop from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false; // The number is divisible by i
                    break; // Exit the loop as it's not a prime number
                }
            }

            // Output the result
            if (isPrime)
            {
                Console.WriteLine("The number is a Prime Number.");
            }
            else
            {
                Console.WriteLine("The number is NOT a Prime Number.");
            }
		}
	}
}