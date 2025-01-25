using System;

class Program{
	static void Main(string[] args){
		//Prompt the user to enter a number
		Console.Write("Enter the Number: ");
		int num = int.Parse(Console.ReadLine());
		
		// we are replacing Fizz instead of 3 and its multiple, Buzz instead of 5 and its multiple, FizzBuzz instead of 3X5 and its multiple using for loop
		for(int i=1;i<=num;i++){
			if(i%3==0 && i%5==0){
				Console.WriteLine("FizzBuzz");
			}
			else if (i%3==0){
				Console.WriteLine("Fizz");
			}
			else if(i%5==0){
				Console.WriteLine("Buzz");
			}
			else{
				Console.WriteLine(i);
			}
		}
	}
}