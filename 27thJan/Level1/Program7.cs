using System;

class Program{
	static int naturalNumber(int n){
		int sum=(n*(n+1))/2;
		return sum;
	}
	static void Main(){
		// Prompt the user to enter a number
		Console.Write("Enter the Number: ");
		int n = int.Parse(Console.ReadLine());
		
		Console.WriteLine("The sum of the n natural Numbers is "+naturalNumber(n));
	}
}